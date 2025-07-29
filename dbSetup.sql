CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL PRIMARY KEY COMMENT 'primary key',
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255) COMMENT 'User Name',
  email VARCHAR(255) UNIQUE COMMENT 'User Email',
  picture VARCHAR(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE burgers(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  price DECIMAL(4, 2) NOT NULL,
  toppings ENUM ('tomato', 'pickels', 'lettuce', 'fig jam'),
  is_lettuce_wrap BOOLEAN DEFAULT FALSE,
  sauce ENUM ('ketchup', 'mayo', 'mustard', 'special sauce'),
  description VARCHAR(255) NOT NULL
);

DROP TABLE burgers;

INSERT INTO
  burgers (
    name,
    price,
    toppings,
    is_lettuce_wrap,
    sauce,
    description
  )
VALUES
  (
    'The Cowboy',
    12.24,
    'pickels',
    FALSE,
    'special sauce',
    'The mcrib is back at mcdonald\'s, now for only $5.86! C\'mon down and eat it, Fatty!'
  );