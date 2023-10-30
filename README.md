# Tailwind CSS + Blazor.NET + Flowbite Starter
Get started with this starter project based on a Tailwind CSS, Blazor.NET and Flowbite configuration to help you ger started building website applications based on the utility classes from Tailwind CSS and components from Flowbite.

This repository is based on the Tailwind CSS + Blazor.NET guide on the Flowbite website. 

## Getting started
Ensure that you have NPM and Node.js installed on your project. Also ensure you have installed the .NET SDK to enable you to develop .NET applications. Run the following command to install all dependencies:

```Bash
npm install
```

Then run this command to compile the source code and watch for changes:

```Bash
dotnet watch
```

Make sure that you also run the following script to compile the Tailwind CSS source code:

```Bash
npx tailwindcss -i wwwroot/css/app.css -o wwwroot/css/app.min.css --watch
```

Run this command to build your project and all its dependencies:

```Bash
dotnet build
```
## Flowbite Components
## Flowbite Components in a Blazor Project
Now that you have successfully installed Blazor.NET, Tailwind CSS and Flowbite, you can start using Flowbite's components such as navbars, buttons, and modals in your project.

We'll use a dropdown component with the hover effect as an example. Copy/paste this [code block](https://flowbite.com/docs/components/dropdowns/) into your Pages/Index.razor file:

```Bash
@page "/"

<button id="dropdownHoverButton" data-dropdown-toggle="dropdownHover" data-dropdown-trigger="{hover|click}" class="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center inline-flex items-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800" type="button">Dropdown hover <svg class="w-2.5 h-2.5 ml-2.5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 10 6">
    <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="m1 1 4 4 4-4"/>
  </svg></button>
<!-- Dropdown menu -->
<div id="dropdownHover" class="z-10 hidden bg-white divide-y divide-gray-100 rounded-lg shadow w-44 dark:bg-gray-700">
    <ul class="py-2 text-sm text-gray-700 dark:text-gray-200" aria-labelledby="dropdownHoverButton">
      <li>
        <a href="#" class="block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white">Dashboard</a>
      </li>
      <li>
        <a href="#" class="block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white">Settings</a>
      </li>
      <li>
        <a href="#" class="block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white">Earnings</a>
      </li>
      <li>
        <a href="#" class="block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white">Sign out</a>
      </li>
    </ul>
</div>

```

[Learn more](https://github.com/themesberg/flowbite-blazor) about the Flowbite-Blazor library and how to customize it to your project.

## License
This project is open-source under the MIT license.