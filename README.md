# Klazapp Network Utility for Unity

## Introduction
The Klazapp Network Utility is a comprehensive Unity Editor tool designed to streamline network requests within your Unity projects. This tool enhances productivity by providing developers with a unified approach to handle various types of HTTP requests, simplifying the integration with web services and APIs.

## Features
- **Unified API Handling**: Supports GET, POST, PUT, and DELETE HTTP methods.
- **Binary Data Support**: Ability to send and receive binary data with custom headers.
- **Configurable Endpoints**: Easily configure and manage API endpoints through ScriptableObject templates.
- **Request Building**: Simplifies the creation of network requests with a consistent interface.
- **Error Handling**: Integrated error handling and callback mechanisms for network requests.
- **Custom Headers**: Support for custom header configurations for API requests.

## Dependencies
This tool requires:
- **Unity 2020.3 LTS or newer**: Ensures compatibility and stability within the latest Unity environments.

## Compatibility
| Compatibility | URP | BRP | HDRP |
|---------------|-----|-----|------|
| Compatible    | ✔️   | ✔️   | ✔️    |

## Installation
1. Clone or download the repository containing the Klazapp Network Utility.
2. Import the tool into your Unity project via `Assets > Import Package > Custom Package`.
3. Ensure the tool's scripts are placed under the `Packages` or `Assets` directory to maintain proper script compilation.

## Usage
To utilize the Network Utility, follow these steps:
- **Setting Up Network Requests**:
  - Implement the `INetworkWebRequestBuilder` and `INetworkWebRequestSender` interfaces to create and send network requests.
  - Use `BuildRequest` or `BuildBinaryRequest` methods to generate `UnityWebRequest` objects.
  - Use `SendWebRequest` method to send requests and handle responses with callbacks.
- **Configuring API Endpoints**:
  - Create a new ScriptableObject using the `Network Api Config Template`.
  - Define the base URL and endpoint paths within the `NetworkApiConfigComponent`.
  - Use `BuildUrl` method to generate full URLs for API requests.

## Example Code
Here's a basic example of how to use the Klazapp Network Utility:

```csharp
using UnityEngine;
using UnityEngine.Networking;
using com.Klazapp.Utility;

public class ExampleUsage : MonoBehaviour
{
    public NetworkApiConfigTemplate apiConfigTemplate;

    void Start()
    {
        var request = apiConfigTemplate.networkApiConfigComponent.BuildRequest(NetworkHttpMethod.Get, "your/api/endpoint");
        StartCoroutine(apiConfigTemplate.networkApiConfigComponent.SendWebRequest(request, OnSuccess, OnError));
    }

    void OnSuccess(UnityWebRequest request)
    {
        Debug.Log("Request successful: " + request.downloadHandler.text);
    }

    void OnError(UnityWebRequest request)
    {
        Debug.LogError("Request failed: " + request.error);
    }
}
```

## Customization
Customize network configurations by modifying the ScriptableObject templates:
- **Network API Config**: Located at `Packages/com.klazapp.networkutility/Editor/Data/NetworkApiConfigTemplate.asset`
- **Network Header Config**: Located at `Packages/com.klazapp.networkutility/Editor/Data/NetworkHeaderConfigTemplate.asset`

Adjust these templates to meet specific API requirements or project configurations.

## To-Do List (Future Features)
- **Extended Network Methods**: Include support for additional HTTP methods and advanced features.
- **Improved GUI**: Develop a user interface within Unity to manage and customize network settings directly.
- **Enhanced Error Handling**: Add more detailed error logging and handling mechanisms.

## License
The Klazapp Network Utility is distributed under the MIT License, allowing for extensive customization and use in both personal and commercial projects. See the LICENSE.md file for more details.
