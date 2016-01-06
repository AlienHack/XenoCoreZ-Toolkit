# XenoCoreZ-Toolkit

First Release (07-01-2016)
FileToolkit
- string GetMd5(string path)
- bool CompareFileHash(string pathA, string pathB)

NetworkToolkit
- string GetUrlContent(string urlAddress)
- void DownloadFile(string urlAddress, string path)
- void DownloadFileAndExecute(string urlAddress)

ProcessToolkit
- int GetProcessId(string processName)
- void SuspendProcess(int pid)
- void SuspendProcess(string processName)
- void ResumeProcess(int pid)
- void ResumeProcess(string processName)

RegistryToolkit
- bool CheckRegistryLocalMachine(string baseReg, string keyToCompare,
string valueToCompare)
- bool CheckRegistryCurrentUser(string baseReg, string keyToCompare,
string valueToCompare)
- void WriteRegistryLocalMachine(string baseReg, string baseKey, string
value)
- void WriteRegistryCurrentUser(string baseReg, string baseKey, string
value)

UtilityToolkit
-

MemoryToolkit
-