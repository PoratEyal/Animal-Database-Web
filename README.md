# Animal-Database-Web

The Animal Database Web is a simple online catalog for a pet shop, allowing customers to browse the catalog, view individual animals, and leave comments. The application is built using C#, ASP.NET, CSS, JavaScript, and HTML.
Below is a guide on how to set up and use the Animal Database Web.

## Introduction

The Animal Database Web consists of four main pages:

1. **Home**: This page serves as the welcome page, displaying information about the pet shop and showcasing two animals with the highest number of reviews. It also contains a site map to navigate through the application.

2. **Catalog**: The catalog page lists all the animals in the shop, categorized into Mammals, Reptiles, and Aquatic animals. Customers can select a pet category from a dropdown list to view the animals in that category. Each animal entry in the table has a button to request more detailed information and leave comments, which leads to the Animal page.

3. **Animal**: The animal page displays detailed information about an individual animal, including its name, age, picture, and a short description. Additionally, it shows a list of comments left by customers for that specific animal. Customers can also add their comments about the animal.

4. **Administrator**: This page is accessible only to administrators and allows them to manage the animals in the shop. Administrators can add, edit, and delete animals using this page. It presents the animals and their categories in a table and dropdown list, making it easy for administrators to modify the catalog.

## Installation

To set up the Pet Shop Application locally on your machine, follow these steps:

1. Clone this GitHub repository to your local machine.

2. Make sure you have Microsoft Visual Studio installed, as this is required to run the ASP.NET application.

3. Open the solution file (.sln) in Visual Studio.

4. Create the database (SQL Server).

5. Update the connection string in the `Web.config` file to point to your SQL Server instance.

6. Build the solution to restore the NuGet packages and compile the application.

7. Run the application from Visual Studio, and it should open in your default web browser.

## Usage

Once the Animal Database Web is up and running, you can access the different pages:

- **Home**: The default landing page displaying welcome text and two animals with the most reviews.

- **Catalog**: Browse through the animals categorized by Mammals, Reptiles, and Aquatic. Select a category from the dropdown to view animals in that category. Click on "More Info" to view detailed information and leave comments on a specific animal.

- **Animal**: View detailed information about an individual animal and see existing customer comments. Add your comments using the form provided.

- **Administrator**: Access this page only if you have administrative privileges. Here, you can manage the animals in the shop, including adding, editing, and deleting animals.

- **NewAnimal**: This page allows administrators to insert a new animal into the database.

## License

The Pet Shop Application is released under the [MIT License](LICENSE). Feel free to use, modify, and distribute the application according to the terms of the license.

https://github.com/PoratEyal/Animal-Database-Web/assets/134833213/cdf165e9-ab9d-4aa0-863f-42c9553c8e7f

