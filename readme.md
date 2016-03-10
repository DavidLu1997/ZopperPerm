# ZopperPerm
An efficient permutations/combinations generator, supporting unlimited* lengths.

Written in C# for .NET 4.5

*Limited by system memory to length 11 strings displayed, unlimited for file output (up to system storage space and processing time)

## Minimum requirements
- Intel Pentium 4 or equivalent
- .NET Framework 4.5
- Windows XP or above
- 2 GB RAM (untested)
- 1GB HDD

## Releases

.NET Framework 4.5 64 bit is required for all releases, get it [here](https://www.microsoft.com/en-ca/download/details.aspx?id=30653).

- [Latest stable release (v1.3.0)](https://github.com/DavidLu1997/ZopperPerm/releases/tag/v1.3.0)
- [Nightly build](https://github.com/DavidLu1997/ZopperPerm/blob/master/ZopperPerm.exe)

## Compilation Instructions

Open `ZopperPerm.sln` with Visual Studio 2013, `ctrl-f5` to build and run.

## Changelog

### v1.4.0 (Future)
- Implemented regular expressions ([] operator)
- Implemented multithreading
- Refactored

### v1.3.0
- Implemented streamlined UI
- Enforced file output
- Refactored for web deployment

### v1.2.2
- Fixed file output bugs
- Known issue: File output does not check for distinct values

### v1.2.1
- Changed to 32 bit compilation
- Disabled screen output for n = 11
- UNSTABLE

### v1.2.0
- Added file output
- Now supports unlimited* lengths
- Working on multithreading

### v1.1.1
- Deleted duplicate entries
- Added total count

### v1.1.0
- Working for n = 11, takes up 7GB of memory though...
- Changed to 64bit
- Deleted progress bar

### v1.0.0
- Initial release
- Base functionality complete
- Working on n > 10
