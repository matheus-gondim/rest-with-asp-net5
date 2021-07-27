CREATE SEQUENCE persons_seq;

CREATE TABLE IF NOT EXISTS persons (
  id bigint NOT NULL DEFAULT NEXTVAL ('persons_seq'),
  first_name varchar(80) NOT NULL,
  last_name varchar(80) NOT NULL,
  address varchar(100) NOT NULL,
  gender varchar(6) NOT NULL,
  enabled boolean NOT NULL DEFAULT TRUE,
  PRIMARY KEY (id)
);
