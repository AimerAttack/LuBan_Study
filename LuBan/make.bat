set WORKSPACE=.

set GEN_CLIENT=%WORKSPACE%\Tools\Luban.ClientServer\Luban.ClientServer.exe
set CONF_ROOT=%WORKSPACE%\..\Config


%GEN_CLIENT% -j cfg --^
 -d %WORKSPACE%\Defines\__root__.xml ^
 --input_data_dir %CONF_ROOT% ^
 --output_code_dir ..\Assets/Gen ^
 --output_data_dir ..\GenerateDatas\bin ^
 --gen_types code_cs_unity_bin,data_bin,data_json ^
 -s all ^
 --l10n:input_text_files ..\Config/lang.xlsx ^
 --l10n:text_field_name text_en ^
 --l10n:output_not_translated_text_file NotLocalized_CN.txt

pause