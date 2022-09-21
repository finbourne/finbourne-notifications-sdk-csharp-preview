FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Notifications.Sdk.sln /usr/src/
COPY Finbourne.Notifications.Sdk/Finbourne.Notifications.Sdk.csproj /usr/src/Finbourne.Notifications.Sdk/
RUN dotnet restore Finbourne.Notifications.Sdk

ENTRYPOINT dotnet build --configuration Release --verbosity normal