docker-machine ssh default docker run -d -P --name selenium-hub selenium/hub
docker-machine ssh default docker run -d --link selenium-hub:hub --name selenium-chrome1 selenium/node-chrome
docker-machine ssh default docker run -d --link selenium-hub:hub --name selenium-chrome2 selenium/node-chrome
docker-machine ssh default docker run -d --link selenium-hub:hub --name selenium-chrome3 selenium/node-chrome
docker-machine ssh default docker run -d --link selenium-hub:hub --name selenium-chrome4 selenium/node-chrome
docker-machine ssh default docker port selenium-hub