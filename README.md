# Klazapp Script Creator for Unity

## Introduction
The Klazapp Script Creator is a powerful Unity Editor tool designed to automate the creation of scripts from predefined templates. This tool enhances productivity by providing developers with quick access to generating both MonoBehaviour and ScriptableObject scripts, ensuring that scripts adhere to project standards and reducing manual setup time.

## Features
- **Script Generation**: Instantly generate scripts for MonoBehaviour and ScriptableObject directly from the Unity Editor.
- **Easy Access**: Accessible through menu selections and right-click context menus in the Project window.
- **Template Customization**: Comes with editable templates for common script types, ensuring consistency across your projects.
- **Context Sensitivity**: Validates directories to prevent scripts from being created in restricted areas such as `Packages` or `Editor`.

## Dependencies
This tool requires:
- **Unity 2020.3 LTS or newer**: Ensures compatibility and stability within the latest Unity environments.

## Compatibility
| Compatibility | URP | BRP | HDRP |
|---------------|-----|-----|------|
| Compatible    | ✔️   | ✔️   | ✔️    |

## Installation
1. Clone or download the repository containing the Klazapp Script Creator.
2. Import the tool into your Unity project via `Assets > Import Package > Custom Package`.
3. Ensure the tool's scripts are placed under the `Packages` or `Assets` directory to maintain proper script compilation.

## Usage
To utilize the Script Creator, follow these steps:
- **For MonoBehaviour Scripts**:
  - Navigate to `Klazapp > Create > MonoBehaviour Script` in the Unity main menu.
  - Alternatively, right-click in the Project window and select `Assets > Create > Klazapp > MonoBehaviour Script`.
- **For ScriptableObject Scripts**:
  - Choose `Klazapp > Create > ScriptableObject Script` from the Unity main menu.
  - Or, right-click in the Project window and go to `Assets > Create > Klazapp > ScriptableObject Script`.

Scripts will be instantiated in the selected directory within the Project window, with checks to prevent creation in non-asset directories.

## Customization
Customize script templates by modifying the files located at:
- **MonoBehaviour**: `Packages/com.klazapp.scriptcreator/Editor/Data/MonoBehaviourTemplate.cs.txt`
- **ScriptableObject**: `Packages/com.klazapp.scriptcreator/Editor/Data/ScriptableObjectTemplate.cs.txt`

Adjust these templates to meet specific coding guidelines or project requirements.

## To-Do List (Future Features)
- **Extended Script Types**: Include templates for custom editors, interfaces, and other Unity script types.
- **GUI for Template Management**: Develop a user interface within Unity to manage and customize script templates directly.

## License
The Klazapp Script Creator is distributed under the MIT License, allowing for extensive customization and use in both personal and commercial projects. See the LICENSE.md file for more details.
