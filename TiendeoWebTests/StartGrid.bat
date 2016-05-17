docker run -d -P --name selenium-hub selenium/hub
docker run -d --link selenium-hub:hub --name selenium-chrome1 selenium/node-chrome
docker run -d --link selenium-hub:hub --name selenium-chrome2 selenium/node-chrome
docker run -d --link selenium-hub:hub --name selenium-chrome3 selenium/node-chrome
docker run -d --link selenium-hub:hub --name selenium-chrome4 selenium/node-chrome
docker port selenium-hub