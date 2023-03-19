# COBOL Tag Lines VSIX Extension 🏷️💻

This VSIX extension for Visual Studio Code makes it easy to add and manage tags in your COBOL code! Use custom tags to mark your tickets and relate them to your work with just a few keyboard shortcuts.

## Features 🌟

- Quickly create tags in the first 6 columns of a row in your COBOL code
- Easily tag one or more lines
- Comment out code while preserving your tags

## Installation 💾

1. Clone this repository to your local machine.
2. Build the project by following the build instructions in the [BUILD](BUILD.md) file.
3. Locate the generated `.vsix` file in the `dist` folder.
4. Install the `.vsix` file in Visual Studio Code by clicking on it or using the "Install from VSIX" command in the Extensions view.
5. Reload VS Code and open a COBOL file.

## Usage 🛠️

1. Use the hotkey `Ctrl + 1` to specify your custom tag.
2. Select one or more lines and press `Ctrl + 2` to add your custom tag to the selected lines.
3. Comment out code while keeping your tag intact with `Ctrl + 3`.

## Keyboard Shortcuts ⌨️

| Shortcut | Action                                 |
| -------- | -------------------------------------- |
| Ctrl + 1 | Specify custom tag                     |
| Ctrl + 2 | Tag selected lines                     |
| Ctrl + 3 | Comment out code while preserving tags |

## Contributing 🤝

If you'd like to contribute to this project, feel free to submit a pull request or open an issue. We appreciate your help!

## License 📜

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Support ❤️

If you like this extension, don't forget to give it a star ⭐ on GitHub and leave a review on the Visual Studio Code Marketplace. Your feedback is greatly appreciated!

## TODO 📝

- Make the hotkey customizable through the extension settings
