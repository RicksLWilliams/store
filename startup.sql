--git remote add origin https://github.com/RicksLWilliams/store.git
--git push -u origin master


CREATE TABLE shoes (
  id INT NOT NULL AUTO_INCREMENT,
  title VARCHAR(80) NOT NULL,
  details VARCHAR(255),
  Style VARCHAR(255),
  Color VARCHAR(255),
  Size VARCHAR(255),
  Supply INT NOT NULL,
  PRIMARY KEY (id)
)