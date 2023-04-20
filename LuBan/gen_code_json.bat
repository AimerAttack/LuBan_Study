set WORKSPACE=.

set GEN_CLIENT=%WORKSPACE%\Tools\Luban.ClientServer\Luban.ClientServer.exe
set CONF_ROOT=%WORKSPACE%

%GEN_CLIENT% -j cfg --^
 -d %CONF_ROOT%\Defines\__root__.xml ^
 --input_data_dir %CONF_ROOT%\Datas ^
 --output_code_dir ..\Assets/Gen ^
 --output_data_dir ..\GenerateDatas\json ^
 --gen_types code_cs_unity_json,data_json ^
 -s all 

%GEN_CLIENT% -j cfg --^
 -d %CONF_ROOT%\Defines\__root__.xml ^
 --input_data_dir %CONF_ROOT%\Datas ^
 --output_code_dir ..\Assets/Gen ^
 --output_data_dir ..\GenerateDatas\bin ^
 --gen_types code_cs_unity_bin,data_bin ^
 -s all 
 

pause