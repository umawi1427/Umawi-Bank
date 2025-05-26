CREATE TABLE signup (
    id VARCHAR(50) NOT NULL,
    firstname NVARCHAR(50) NOT NULL,
    surname NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL,
    birthdate DATE NOT NULL,
    birthplace NVARCHAR(50) NOT NULL,
    [phone number] VARCHAR(50) NOT NULL,
    email NVARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
);
CREATE TABLE accounts (
    accountid VARCHAR(50) NOT NULL PRIMARY KEY,
    userid VARCHAR(50) NOT NULL,
    accountname NVARCHAR(100) NOT NULL,
    accountcreatedon DATETIME NOT NULL,
    currency NVARCHAR(10) NOT NULL,
    balance DECIMAL(15, 2) NOT NULL,
    FOREIGN KEY (userid) REFERENCES signup(id)
);
CREATE TABLE transactions (
    transactionid VARCHAR(50) NOT NULL PRIMARY KEY,
    accountid VARCHAR(50) NOT NULL,
    transactiondate DATETIME NOT NULL,
    amount DECIMAL(18, 2) NOT NULL,
    transactiontype NVARCHAR(50) NOT NULL,
    FOREIGN KEY (accountid) REFERENCES accounts(accountid)
);
CREATE TABLE messages (
    senderid VARCHAR(50) NOT NULL,
    senderemail NVARCHAR(255) NOT NULL,
    messagecontent NVARCHAR(MAX) NOT NULL,
    sentdate DATETIME NOT NULL,
    FOREIGN KEY (senderid) REFERENCES signup(id)
);