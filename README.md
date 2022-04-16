# Demo of a NullReferenceException in (pure?) FSharp unit-test

It happens after removing the `[<EntryPoint>]` (e.g. in the auto-generated `Program.fs` file).

```shell
git checkout NRE     # for the failing configuration
git checkout PASSING # for the working configuration
```

The projects where was initiated as follows:

```shell
mkdir $BASE_FOLDER
cd $BASE_FOLDER
dotnet new sln
dotnet new xunit -lang 'F#' -o XUnitCase
dotnet sln add XUnitCase
dotnet new nunit -lang 'F#' -o NUnitCase
dotnet sln add NUnitCase
```