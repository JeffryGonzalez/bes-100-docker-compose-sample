FROM mcr.microsoft.com/dotnet/core/sdk
LABEL author="Jeff Gonzalez"

COPY . /app
WORKDIR /app
RUN dotnet restore
RUN dotnet build
EXPOSE 5000
ENTRYPOINT [ "dotnet", "watch", "run" ]