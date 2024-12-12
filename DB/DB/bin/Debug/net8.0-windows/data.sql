DROP TABLE accounts;

CREATE TABLE accounts (
    id INTEGER PRIMARY KEY,
    login TEXT NOT NULL UNIQUE,
    password TEXT NOT NULL,
    admin TEXT NOT NULL
);

INSERT INTO accounts(id,login,password,admin)
VALUES(1,"WhatTheMeg","admin","YES");