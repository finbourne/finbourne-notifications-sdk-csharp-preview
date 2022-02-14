FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Notifications.Sdk.sln /usr/src/
COPY Finbourne.Notifications.Sdk/Finbourne.Notifications.Sdk.csproj /usr/src/Finbourne.Notifications.Sdk/
RUN dotnet restore Finbourne.Notifications.Sdk

ENV FBN_NOTIFICATIONS_API_URL ${FBN_NOTIFICATIONS_API_URL}

# ENTRYPOINT [ "/bin/bash" ]
ENTRYPOINT dotnet build --configuration Release -verbosity normal Finbourne.Notifications.Sdk