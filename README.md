# AcuCafe Full Stack Developer Assessment

AcuCafe has an ordering system which is poorly designed and sometime fails to deliver the right orders. For example, some of the clients complain that their ice tea had milk in it. The system has also turned out to be a maintenance nightmare as they add new drinks every month and this is difficult to do. They have hired you to solve these problems. 

The client has asked for the following (work down the list) 
- Stop the preparation of an ice tea with milk and inform the barista 
- Errors should be handled both front and back end  
- Fix the order summary so it displays the drink and cost 
- It should look like the designs in Figma: [here](https://www.figma.com/file/oqGXgrX6769HUXv37t5tFM/Front-End-AcuCafe?type=design&node-id=26%3A3783&mode=design&t=h9QNdfPBo964hnLm-1)
- See the cost with toppings before placing an order 
- Able to order multiple drinks at once 
- See previous orders

During you work you should consider, scalability, validation, maintainability, the user experience and separation of concerns between front-end and back-end. You may not be able to make all the changes you want, so you can talk us through any changes you would make with more time.  

## System Requirements

The project consists of a .NET 8 API and an Angular 18 front-end. You’ll need the 
following on your computer to run this:

### Docker
 - Docker Desktop

## Inspecting Designs

It should be fairly easy to inspect the designs in Figma. Just ensure you create a free account 
at figma.com so that you can click around and inspect things like colours and fonts.

If you’re unfamiliar with where to find these things in Figma, take a look at this article: [An Overview of Figma for Developers](https://www.figma.com/best-practices/tips-on-developer-handoff/an-overview-of-figma-for-developers/)


## Running the app
You can either run the app locally on your m/c, or use docker compose.

Docker will get you up and running quicker and changes to the code will be reflected in the UI, source maps are included in the Angular build so you can debug in the browser, but you won't be able to debug the API.
If you run locally you can debug both, a .vscode debug configuration is included in the repo (api only).

### Run the app locally

#### Run up the SPA
```bash
cd ./spa
npm install
ng serve
```

#### Run up the API
```bash
cd ./api
dotnet run
```
*Or start the api in debug using vscode extension*

### Run the app in Docker
- Ensure you are in the `acucafe-fullstack` directory
- Start the apps
    - `docker compose up -d`
- Stop the apps
    - `docker compose down`
