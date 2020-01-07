FROM mcr.microsoft.com/dotnet/core/sdk
LABEL author="Jeff Gonzalez"

COPY . /app
WORKDIR /app
RUN dotnet restore
RUN dotnet build
RUN dotnet tool restore
EXPOSE 5000
RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh