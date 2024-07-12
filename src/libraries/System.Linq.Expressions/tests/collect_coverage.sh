set -ex

rm -rf TestResults
COMPlus_gcServer=0 COMPlus_GCHeapHardLimit=0x400000000 COMPlus_GCHighMemPercent=0x5A dotnet test --configuration Debug --logger "console;verbosity=normal" --collect:"XPlat Code Coverage" /p:Exclude=\"[xunit\*]\*\" /p:CoverletOutput="./obj/coverage/" CompileToMethod.Tests.csproj
file=$(find TestResults -name "*.xml")
DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=true dotnet reportgenerator -reports:$file -targetdir:TestResults/html -reporttypes:HTML ./CompileToMethod.Tests.csproj
