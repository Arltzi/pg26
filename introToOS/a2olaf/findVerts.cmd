REM Copyright 2024 Lev Zitron. All rights reserved
@ECHO off

REM Set substring to "v " by default
SET searchString="v "
REM If user passes a different substring as the first parameter, change searchString to that passed string, otherwise leave it
IF NOT "%1"=="" SET searchString="%1"

REM Make a folder to contain the data and app
MKDIR H:\Builds\LevZitronA2\CatchingAHorse

REM Copy StudioPoseOlaf.obj to the new folder in h drive
COPY StudioPoseOLAF.obj H:\Builds\LevZitronA2

REM Copy CatchingAHorse folder and all subfolder to new folder in h drive
REM Using ROBOCOPY because it easily copies all subfolder, subfiles, and hidden files!! not even XCOPY copies hidden files well
ROBOCOPY CatchingAHorse H:\Builds\LevZitronA2\CatchingAHorse /E

REM count all appearances of substring (defaults to "v ") in StudioPoseOlaf.obj once its been transferred to h drive
REM output count to NumberOfVertices.txt, creating it if it doesnt exist
FIND /c %searchString% H:\Builds\LevZitronA2\StudioPoseOLAF.obj > H:\Builds\LevZitronA2\NumberOfVertices.txt