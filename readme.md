# ZopperPerm
An efficient permutations/combinations generator, supporting unlimited* lengths.

Written in C# for .NET 4.5

*Limited by system memory, currently limited at 11, working on optimizations

## Releases

.NET Framework 4.5 64 bit is required for all releases, get it [here](https://www.microsoft.com/en-ca/download/details.aspx?id=30653).

- [Latest stable release (v1.1.1)](https://github.com/DavidLu1997/ZopperPerm/releases/tag/v1.1.1)
- [Nightly build](https://github.com/DavidLu1997/ZopperPerm/blob/master/ZopperPerm.exe)

## Compilation Instructions

Open `ZopperPerm.sln` with Visual Studio 2013, `ctrl-f5` to build and run.

## Changelog

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
