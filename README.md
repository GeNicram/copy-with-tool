# copy-with-tool
Simple graphical interface for executing command on each file in directory.  

This applications allows to execute other program to modify many files and store it in different location. Application keeps directory tree.  

### How to
I usually use this tool to compress with 7zip many files separately and store it on pen drive. I'm doing in in following way:  
1. Select tool program which will be run for each file. In my case it is "7za.exe"  
2. Select directory with files to compress.  
3. Select where compressed files will be stored.  
4. Write command like in command line. It is hardest step. For compressing with 7 zip it will be: "a -t7z {1n}.7z {0}" which means:  
  a - archive  
  -t7z - use 7zip compression  
  {1n}.7z - insert destination path without extension, and add ".7z"  
  {0} - insert source file  
5. Click copy to being.    

  To decompress files use command: "e {0} -o{1d}", which means:  
  e - extract  
  {0} - insert source file  
  -o{1d} - insert output directory  
  
  
the truth speaking, this tool is useless :)
