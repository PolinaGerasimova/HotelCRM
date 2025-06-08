-- Удаляем базу данных, если она существует
DROP DATABASE IF EXISTS hotel_crm;

-- Создаем новую базу данных с кодировкой
CREATE DATABASE hotel_crm CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Переключаемся на неё
USE hotel_crm;


-- Категории номеров
CREATE TABLE RoomCategories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL UNIQUE COMMENT 'Название категории (Бюджетный, Стандарт, Комфорт, Люкс)',
    Description TEXT NULL COMMENT 'Описание категории'
) COMMENT 'Категории номеров';


-- Номера отеля
CREATE TABLE Rooms (
    RoomID INT AUTO_INCREMENT PRIMARY KEY,
    RoomNumber VARCHAR(10) NOT NULL UNIQUE COMMENT 'Номер комнаты',
    CategoryID INT NOT NULL COMMENT 'Ссылка на категорию',
    Description TEXT NULL COMMENT 'Описание номера',
    ImagePath VARCHAR(255) NULL COMMENT 'Путь к изображению номера',
    MaxOccupancy INT NOT NULL CHECK (MaxOccupancy > 0) COMMENT 'Максимальное количество гостей',
    BasePricePerNight DECIMAL(10, 2) NOT NULL CHECK (BasePricePerNight >= 0) COMMENT 'Цена за ночь',
    Status ENUM('Available', 'Occupied', 'Cleaning', 'Maintenance', 'OutOfOrder') NOT NULL DEFAULT 'Available' COMMENT 'Статус номера',
    FOREIGN KEY (CategoryID) REFERENCES RoomCategories (CategoryID) ON DELETE RESTRICT ON UPDATE CASCADE
) COMMENT 'Номера отеля';


-- Гости
CREATE TABLE Guests (
    GuestID INT AUTO_INCREMENT PRIMARY KEY,
    LastName VARCHAR(100) NOT NULL COMMENT 'Фамилия',
    FirstName VARCHAR(100) NOT NULL COMMENT 'Имя',
    MiddleName VARCHAR(100) NULL COMMENT 'Отчество',
    PhoneNumber VARCHAR(11) NOT NULL COMMENT 'Телефон (хранится как 11 цифр, начиная с 7)',
    PassportSeries VARCHAR(4) NULL COMMENT 'Серия паспорта',
    PassportNumber VARCHAR(6) NULL COMMENT 'Номер паспорта',
    PassportIssueDate DATE NULL COMMENT 'Дата выдачи паспорта',
    PassportIssuedBy VARCHAR(100) NULL COMMENT 'Кем выдан паспорт',
    BirthDate DATE NULL COMMENT 'Дата рождения',
    Email VARCHAR(100) NULL COMMENT 'Email',
    Notes TEXT NULL COMMENT 'Примечания',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) COMMENT 'Гости отеля';


-- Сотрудники
CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL COMMENT 'Имя',
    LastName VARCHAR(50) NOT NULL COMMENT 'Фамилия',
    MiddleName VARCHAR(50) NULL COMMENT 'Отчество',
    Role VARCHAR(100) NOT NULL COMMENT 'Должность (например, "Администратор", "Горничная")',
    PhoneNumber VARCHAR(20) NULL COMMENT 'Телефон',
    EmploymentDate DATE NOT NULL COMMENT 'Дата приема на работу',
    WorkSchedule TEXT NULL COMMENT 'График работы',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) COMMENT 'Сотрудники отеля';


-- Пользователи системы (для авторизации)
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE COMMENT 'Логин',
    PasswordHash VARCHAR(255) NOT NULL COMMENT 'Хеш пароля',
    Role ENUM('Administrator', 'Receptionist', 'Housekeeper', 'Technician') NOT NULL COMMENT 'Роль пользователя',
    EmployeeID INT NULL COMMENT 'Ссылка на сотрудника (если пользователь является сотрудником)',
    IsActive BOOLEAN NOT NULL DEFAULT TRUE COMMENT 'Активен ли пользователь',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID) ON DELETE SET NULL ON UPDATE CASCADE
) COMMENT 'Пользователи системы для авторизации';


-- Тарифы
CREATE TABLE Tariffs (
    TariffID INT AUTO_INCREMENT PRIMARY KEY,
    TariffName VARCHAR(100) NOT NULL UNIQUE COMMENT 'Название тарифа',
    DiscountPercentage DECIMAL(5, 2) NOT NULL CHECK (DiscountPercentage BETWEEN 0 AND 100) COMMENT 'Процент скидки',
    StartDate DATE NOT NULL COMMENT 'Дата начала действия',
    EndDate DATE NOT NULL COMMENT 'Дата окончания действия',
    IsActive BOOLEAN NOT NULL DEFAULT TRUE COMMENT 'Активен ли тариф',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) COMMENT 'Тарифы отеля';


-- Бронирования
CREATE TABLE Bookings (
    BookingID INT AUTO_INCREMENT PRIMARY KEY,
    GuestID INT NOT NULL COMMENT 'Ссылка на гостя',
    RoomID INT NOT NULL COMMENT 'Ссылка на номер',
    CheckInDate DATE NOT NULL COMMENT 'Дата заезда',
    CheckOutDate DATE NOT NULL COMMENT 'Дата выезда',
    BookingDate TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Дата создания брони',
    NumberOfGuests INT NOT NULL CHECK (NumberOfGuests > 0) COMMENT 'Количество гостей',
    TariffID INT NULL COMMENT 'Ссылка на примененный тариф',
    Status ENUM('Confirmed', 'CheckedIn', 'CheckedOut', 'Cancelled') NOT NULL DEFAULT 'Confirmed',
    ActualCheckInTime DATETIME NULL COMMENT 'Фактическое время заезда',
    ActualCheckOutTime DATETIME NULL COMMENT 'Фактическое время выезда',
    TotalPriceAccommodation DECIMAL(10, 2) NULL COMMENT 'Общая стоимость проживания (вычисляется в C#)',
    TotalPriceServices DECIMAL(10, 2) NOT NULL DEFAULT 0.00 COMMENT 'Общая стоимость дополнительных услуг',
    FinalBillAmount DECIMAL(10, 2) GENERATED ALWAYS AS (TotalPriceAccommodation + TotalPriceServices) STORED COMMENT 'Итоговая сумма к оплате',
    Notes TEXT NULL COMMENT 'Примечания',
    FOREIGN KEY (GuestID) REFERENCES Guests (GuestID) ON DELETE RESTRICT ON UPDATE CASCADE,
    FOREIGN KEY (RoomID) REFERENCES Rooms (RoomID) ON DELETE RESTRICT ON UPDATE CASCADE,
    FOREIGN KEY (TariffID) REFERENCES Tariffs (TariffID) ON DELETE SET NULL ON UPDATE CASCADE,
    CONSTRAINT CK_BookingDates CHECK (CheckInDate < CheckOutDate)
) COMMENT 'Бронирования номеров';


-- Дополнительные услуги
CREATE TABLE Services (
    ServiceID INT AUTO_INCREMENT PRIMARY KEY,
    ServiceName VARCHAR(100) NOT NULL UNIQUE COMMENT 'Название услуги',
    Price DECIMAL(10, 2) NOT NULL CHECK (Price >= 0) COMMENT 'Цена услуги',
    Description TEXT NULL COMMENT 'Описание услуги',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) COMMENT 'Дополнительные услуги';


-- Услуги в бронировании
CREATE TABLE BookingServices (
    BookingServiceID INT AUTO_INCREMENT PRIMARY KEY,
    BookingID INT NOT NULL COMMENT 'Ссылка на бронирование',
    ServiceID INT NOT NULL COMMENT 'Ссылка на услугу',
    ServiceDate DATE NULL COMMENT 'Дата предоставления услуги (если на конкретную дату)',
    Quantity INT NOT NULL DEFAULT 1 CHECK (Quantity > 0) COMMENT 'Количество',
    ItemPrice DECIMAL(10, 2) NOT NULL COMMENT 'Цена услуги на момент добавления',
    TotalPrice DECIMAL(10, 2) GENERATED ALWAYS AS (ItemPrice * Quantity) STORED COMMENT 'Общая стоимость этой услуги для брони',
    Notes TEXT NULL COMMENT 'Примечания',
    FOREIGN KEY (BookingID) REFERENCES Bookings (BookingID) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (ServiceID) REFERENCES Services (ServiceID) ON DELETE RESTRICT ON UPDATE CASCADE,
    UNIQUE KEY UK_BookingServiceDate (BookingID, ServiceID, ServiceDate)
) COMMENT 'Услуги, добавленные к бронированию';


-- Задачи по уборке
CREATE TABLE CleaningTasks (
    CleaningTaskID INT AUTO_INCREMENT PRIMARY KEY,
    RoomID INT NULL COMMENT 'Ссылка на номер',
    AreaName VARCHAR(100) NULL COMMENT 'Название зоны (например: Парковка, Беседка)',
    EmployeeID INT NULL COMMENT 'Ссылка на исполнителя',
    ScheduledDate DATE NOT NULL COMMENT 'Планируемая дата',
    TaskType VARCHAR(100) NOT NULL COMMENT 'Тип уборки/работы',
    Description TEXT NULL COMMENT 'Описание задачи',
    Status ENUM('Scheduled', 'InProgress', 'Completed', 'Postponed', 'Cancelled') NOT NULL DEFAULT 'Scheduled',
    CompletionDate DATETIME NULL COMMENT 'Дата выполнения',
    Notes TEXT NULL COMMENT 'Примечания',
    FOREIGN KEY (RoomID) REFERENCES Rooms (RoomID) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID) ON DELETE SET NULL ON UPDATE CASCADE
) COMMENT 'Задачи по уборке номеров и территорий';


-- Обслуживание и ремонт номеров
CREATE TABLE RoomMaintenance (
    MaintenanceID INT AUTO_INCREMENT PRIMARY KEY,
    RoomID INT NOT NULL COMMENT 'Ссылка на номер',
    EmployeeID INT NULL COMMENT 'Ссылка на исполнителя',
    TaskDescription TEXT NOT NULL COMMENT 'Описание задачи',
    ReportedDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    ScheduledStartDate DATETIME NULL,
    ScheduledEndDate DATETIME NULL,
    ActualCompletionDate DATETIME NULL,
    Status ENUM('Reported', 'Scheduled', 'InProgress', 'Completed', 'Cancelled', 'AwaitingParts') NOT NULL DEFAULT 'Reported',
    Cost DECIMAL(10, 2) NULL CHECK (Cost >= 0),
    Notes TEXT NULL,
    FOREIGN KEY (RoomID) REFERENCES Rooms (RoomID) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID) ON DELETE SET NULL ON UPDATE CASCADE
) COMMENT 'Задачи обслуживания и ремонта номеров';


-- Индексы для ускорения поиска
ALTER TABLE Guests ADD INDEX idx_guest_lastname (LastName);
ALTER TABLE Guests ADD INDEX idx_guest_phone (PhoneNumber);
ALTER TABLE Rooms ADD INDEX idx_room_status (Status);
ALTER TABLE Bookings ADD INDEX idx_booking_dates (CheckInDate, CheckOutDate);
ALTER TABLE Bookings ADD INDEX idx_booking_guest (GuestID);
ALTER TABLE Bookings ADD INDEX idx_booking_room (RoomID);
ALTER TABLE BookingServices ADD INDEX idx_bookingservice_booking (BookingID);


-- Триггеры для автоматического обновления TotalPriceServices при работе с BookingServices

DELIMITER //
CREATE TRIGGER AfterInsertBookingService
AFTER INSERT ON BookingServices
FOR EACH ROW
BEGIN
    UPDATE Bookings
    SET TotalPriceServices = (
        SELECT COALESCE(SUM(TotalPrice), 0)
        FROM BookingServices
        WHERE BookingID = NEW.BookingID
    )
    WHERE BookingID = NEW.BookingID;
END; //
DELIMITER ;


DELIMITER //
CREATE TRIGGER AfterUpdateBookingService
AFTER UPDATE ON BookingServices
FOR EACH ROW
BEGIN
    IF NEW.BookingID <> OLD.BookingID THEN
        -- Обновление старой и новой записи, если они относятся к разным броням
        UPDATE Bookings
        SET TotalPriceServices = (
            SELECT COALESCE(SUM(TotalPrice), 0)
            FROM BookingServices
            WHERE BookingID = OLD.BookingID
        )
        WHERE BookingID = OLD.BookingID;

        UPDATE Bookings
        SET TotalPriceServices = (
            SELECT COALESCE(SUM(TotalPrice), 0)
            FROM BookingServices
            WHERE BookingID = NEW.BookingID
        )
        WHERE BookingID = NEW.BookingID;
    ELSE
        -- Обновление только текущего бронирования
        UPDATE Bookings
        SET TotalPriceServices = (
            SELECT COALESCE(SUM(TotalPrice), 0)
            FROM BookingServices
            WHERE BookingID = NEW.BookingID
        )
        WHERE BookingID = NEW.BookingID;
    END IF;
END; //
DELIMITER ;


DELIMITER //
CREATE TRIGGER AfterDeleteBookingService
AFTER DELETE ON BookingServices
FOR EACH ROW
BEGIN
    UPDATE Bookings
    SET TotalPriceServices = (
        SELECT COALESCE(SUM(TotalPrice), 0)
        FROM BookingServices
        WHERE BookingID = OLD.BookingID
    )
    WHERE BookingID = OLD.BookingID;
END; //
DELIMITER ;


-- Триггеры для проверки наличия RoomID или AreaName в CleaningTasks

DELIMITER //
CREATE TRIGGER BeforeInsertCleaningTask
BEFORE INSERT ON CleaningTasks
FOR EACH ROW
BEGIN
    IF NEW.RoomID IS NULL AND NEW.AreaName IS NULL THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'В задаче по уборке должно быть указано либо RoomID, либо AreaName';
    END IF;
END; //
DELIMITER ;


DELIMITER //
CREATE TRIGGER BeforeUpdateCleaningTask
BEFORE UPDATE ON CleaningTasks
FOR EACH ROW
BEGIN
    IF NEW.RoomID IS NULL AND NEW.AreaName IS NULL THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'В задаче по уборке должно быть указано либо RoomID, либо AreaName';
    END IF;
END; //
DELIMITER ;


-- Примеры данных

INSERT INTO RoomCategories (CategoryName, Description) VALUES
('Эконом', 'Недорогие номера'),
('Стандарт', 'Номера стандартного уровня'),
('Комфорт', 'Номера повышенного комфорта'),
('Люкс', 'Люксовые номера');


INSERT INTO Rooms (RoomNumber, CategoryID, Description, MaxOccupancy, BasePricePerNight, Status)
VALUES ('101', 1, 'Стандартный номер', 2, 3000.00, 'Available');


INSERT INTO Employees (FirstName, LastName, MiddleName, Role, PhoneNumber, EmploymentDate, WorkSchedule)
VALUES ('Иван', 'Иванов', 'Иванович', 'Administrator', '+79991234567', CURDATE(), 'Пн-Пт 9:00-18:00');


INSERT INTO Users (Username, PasswordHash, Role, EmployeeID, IsActive)
VALUES ('admin', SHA2('admin123', 256), 'Administrator', 1, TRUE);


INSERT INTO Services (ServiceName, Price, Description)
VALUES ('Уборка номера', 500.00, 'Ежедневная уборка');