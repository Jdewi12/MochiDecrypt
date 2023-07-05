MochiDecrypt.cs taken from https://github.com/whc2001/MochiCryptUnpacker/ and slightly modified to match a specific MochiCrypt version. Did this because MochiCryptUnpacker just logs a generic error when it fails and I was too lazy to fork it.

To use, extract mochicrypt.Payload binary data with a tool like FFdec and run this program from the command line with the path to the binary data as an argument.
