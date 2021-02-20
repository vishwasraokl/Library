//change to project root folder
CD ..

az acr build -t vishlibrary/library -r vishlibrary -f Library\Dockerfile
