# b64dc2png

`b64dc2png` is a simple utility that decodes a Base64-encoded string and saves the resulting binary data as a PNG image.

## Usage

```bash
b64dc2png <base64_string>
```

Replace `<base64_string>`` with your actual Base64-encoded string.

## Building the Project

To build the project, follow these steps:

Clone the Repository:

```bash
git clone https://github.com/repasscloud/b64dc2png.git
cd b64dc2png
```

Run `dotnet publish` command:

```bash
dotnet publish -c Release -r <runtime-identifier> --self-contained=true /p:PublishSingleFile=true /p:PublishTrimmed=true
```

Replace `<runtime-identifier>` with any of:

| Runtime Identifier (RID) | Description |
|:-------------------------|:------------|
| linux-x64 | Linux, 64-bit |
| linux-x86 | Linux, 32-bit |
| linux-musl-x64 | Linux using musl libc, 64-bit |
| linux-musl-x86 | Linux using musl libc, 32-bit |
| win10-x64 | Windows 10, 64-bit |
| win10-x86 | Windows 10, 32-bit |
| win8-arm | Windows 8 on ARM |
| osx.10.15-x64 | macOS 10.15 Catalina, 64-bit |
| osx.11-x64 | macOS 11 Big Sur, 64-bit |
| osx.12-x64 | macOS 12 Monterey, 64-bit |
| freebsd-x64 | FreeBSD, 64-bit |
| ubuntu.16.04-x64 | Ubuntu 16.04, 64-bit |
| ubuntu.18.04-x64 | Ubuntu 18.04, 64-bit |
| ubuntu.20.04-x64 | Ubuntu 20.04, 64-bit |

## Example
```bash
b64dc2png "SGVsbG8gd29ybGQh"
```

This will decode the provided Base64 string and save the resulting binary data as a PNG image named `output.png`. The program will then print:

```bash
Image saved as output.png
```

## License

This project is licensed under the Apache-2.0 License. Feel free to use and modify it according to your needs.