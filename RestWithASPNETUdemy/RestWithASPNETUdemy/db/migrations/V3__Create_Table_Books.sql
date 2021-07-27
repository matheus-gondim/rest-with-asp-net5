CREATE SEQUENCE books_seq;

CREATE TABLE IF NOT EXISTS books (
  id int NOT NULL DEFAULT NEXTVAL ('books_seq'),
  author varchar(120),
  launch_date timestamp(6) NOT NULL,
  price decimal(65,2) NOT NULL,
  title  varchar(120),
  PRIMARY KEY (id)
);