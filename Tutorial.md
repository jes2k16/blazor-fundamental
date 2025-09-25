full video: https://www.youtube.com/watch?v=CpbRAWgFBRQ

- Project Structure
- Blazor Components
    > you can use the component (Counter.blazor) anywhere
    > you can also add parameters
- Events
    > add onclick, mouseover, keydown, blur
- Data Binding
    > One way - only display the value
    > Two way - data flows in both direction
- Render Modes
    > Static Server Side Rendering  - for plain page
    > Stream Rendering  - loading in the ui while waiting for async get to finish, then render the whole page after
- Interactive Render Modes
    > Interactive Server Rendering      - ui send signal to the server using signalR then update the dom when ui receive the data from the server
    > Interactive WebAssembly Rendering - happened in the client side
    > Interactive Auto Render Mode      - combined the two, use server mode on initial to have fast loading, then after the web assembly was loaded, it will switch to client mode

- Create a new project using auto render modes
    > we now have two projects, the server and the client
    > only the counter page is in the client project, because this is the only one that is interactable, all are static or server mode

