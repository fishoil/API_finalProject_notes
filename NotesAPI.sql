CREATE DATABASE NoteDatabase;

USE NoteDatabase;

CREATE TABLE users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE notes (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255),
    Content TEXT,
    CreatedAt DATETIME NOT NULL,
    UserId INT,
    FOREIGN KEY (UserId) REFERENCES users(Id)
);

INSERT INTO users (Name, Email) VALUES ('Long', 'long@example.com');
INSERT INTO users (Name, Email) VALUES ('John', 'johnCena@gmail.com');

INSERT INTO notes (Title, Content, CreatedAt, UserId) VALUES ('Note 1', 'This is the content of Note 1', NOW(), 1);
INSERT INTO notes (Title, Content, CreatedAt, UserId) VALUES ('Note 2', 'This is the content of Note 2', NOW(), 2);
