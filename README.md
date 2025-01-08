# JSON to XML Converter

## Description
This program converts a JSON file into an XML file. 
It handles complex JSON structures, including arrays (with multiple levels of nesting) and JSON objects. Each element is transformed into a well-formatted XML structure.

The program is written in C# and runs on .NET Framework 4.5. It uses classes like `XmlDocument` to generate the XML file and `JavaScriptSerializer` to deserialize the JSON.

---

## Features
- Converts a JSON file to an XML file.
- Supports JSON arrays.
- Generates well-structured XML files.
- Displays success or error messages after conversion.
- Handles errors for missing files or malformed JSON.

---

## Prerequisites
- **Operating System**: Windows, Mac, Linux
- **Framework**: .NET Framework 4.5(minimum)

---

## Installation

1. Clone or download this project to a local directory.
2. Ensure the following files are present in the project directory:
   - `Program.cs`
   - `Outils.cs`
   - `App.config`
3. Open the project in Visual Studio 2013 or a compatible version.
4. Build the project to generate the executable.

---

## Usage

### Running the Program

1. Open a command prompt in the directory containing the executable (by default, in `bin/Debug` after building).
2. Run the program by providing the path to a JSON file as an argument:

   ```
   Program.exe <path_to_json_file>
   ```

### Example
If you have a JSON file named `example.json`, run:

```cmd
Program.exe example.json
```

The program will:
- Check if the JSON file exists.
- Convert the JSON to XML.
- Save the XML file in the same directory as the JSON file, with the same base name (e.g., `example.xml`).
- Display a success or error message.

---

## Example Input and Output

### Input JSON File
```json
[
    {
        "name": "Alice",
        "age": 25,
        "skills": ["C#", "SQL", "Azure"]
    },
    {
        "name": "Bob",
        "age": 30,
        "skills": ["Java", "Docker", "Kubernetes"]
    }
]
```

### Generated XML File
```xml
<root>
    <item>
        <name>Alice</name>
        <age>25</age>
        <skills>
            <item>C#</item>
            <item>SQL</item>
            <item>Azure</item>
        </skills>
    </item>
    <item>
        <name>Bob</name>
        <age>30</age>
        <skills>
            <item>Java</item>
            <item>Docker</item>
            <item>Kubernetes</item>
        </skills>
    </item>
</root>
```

---

## Included Files
- **`Program.cs`**: Contains the main logic for converting JSON to XML.
- **`Outils.cs`**: Contains auxiliary tools (e.g., colored console output).
- **`App.config`**: Application configuration (target framework).

---

## Error Handling
- **Missing JSON file**:
  - Message: `The specified file <filename> does not exist.`
- **Non-JSON file**:
  - Message: `Conversion error: The file is not a valid JSON.`
- **Malformed JSON structure**:
  - Message: `Conversion error: <detailed_error_message>.`

---

## Customization
- You can modify the conversion behavior in the `ParseJsonToXml` method to handle other JSON structures or customize the generated XML format.
- The `Outils` class is customizable for additional utility functions.

---

## Author
- **Name**: Khasey_Nine_Z
- **Contact**: https://github.com/khasey

---

## License
This project is licensed under the MIT License. You are free to use, modify, and distribute it, provided you retain the original author's attribution.

