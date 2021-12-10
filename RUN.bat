@echo off
@echo 1%%
@echo 10%%
@echo 20%%
@echo 30%%
@echo 40%%
@echo 50%%
@echo 60%%
@echo 70%%
@echo 80%%
@echo 90%%
@echo 100%%
@echo SUCCESSFUL !!!
SQLCMD -E -S .\PHARMACY -i Database/script.sql
PAUSE