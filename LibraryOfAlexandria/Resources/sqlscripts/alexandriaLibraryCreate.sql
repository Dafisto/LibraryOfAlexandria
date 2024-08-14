-- This will create a database if it isn't already created.  It will then create all tables for the database and drop them if they already exist.
--This will also create a spool off in the maui file so there is a reference internally to the tables if needed to look up. 
--

CREATE DATABASE AlexandriaLibrary;
DROP TABLE CLIENTS;
DROP TABLE BOOKRENTAL;
DROP TABLE BOOKS;
DROP TABLE AUTHOR;

CREATE TABLE ALS_CLIENTS
(customerID NUMBER(6) CONSTRAINT cid_pk PRIMARY KEY,
firstName NVARCHAR2(20) CONSTRAINT cli_fname_nn NOT NULL,
lastName NVARCHAR2(20) CONSTRAINT cli_lname_nn NOT NULL,
city NVARCHAR2(20) CONSTRAINT cli_city_nn NOT NULL
);

ALTER TABLE ALS_CLIENTS
    ADD CONSTRAINT cid_ck CHECK(regexp_like(customerID, '[0-9]{6}'));

CREATE TABLE ALS_BOOKRENTAL
(customerID NUMBER(6) CONSTRAINT cid_fk
    REFERENCES ALS_CLIENTS

)