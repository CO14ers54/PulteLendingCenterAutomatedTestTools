for /f "skip=1 tokens=3 usebackq" %%s in (
 `query user %username%`
) do (
 %windir%\\System32\\tscon.exe %%s /dest:console
)