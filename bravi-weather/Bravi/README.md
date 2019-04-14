"Bravi Test"

PS: I made this test on Sunday, because I traveled this weekend.
    I did not have time to apply some DDD Architecture on API and WeatherApp.

----- Balanced Brackets -----

1. Open Bravi\brackets in your terminal.
2. Run "dotnet run".
3. This is a basic console application.


----- Contact List (Simple API, not used DDD Architecture) -----

PS: This API are developed with .Net Core 2.2

1. Open \Bravi\braviApi in your terminal.
2. Run "dotnet restore" to get all dependencies.
3. Run "dotnet run" to start API.
4. I used Postman to test this APi.
5. To test the API follow the endpoints and examples bellow:

    - GET People: http://localhost:5000/api/people
    - GET People by Id: http://localhost:5000/api/people/1
    - POST People: http://localhost:5000/api/people 
                    Example to insert: {
	                                        "Id" : 1,
	                                        "Name" : "Lucas"
                                       }
    - PUT People by Id only: http://localhost:5000/api/people/1
    - DELETE People by Id only: http://localhost:5000/api/people/1


    - GET Contacts: http://localhost:5000/api/contact
    - GET Contact by Id: http://localhost:5000/api/contact/1
    - POST Contact by Id: http://localhost:5000/api/contact
                        Example to insert: {
	                                        "Id" : 1,
	                                        "Email" : "teste@teste.com.br",
                                            "Cel" : 1231412341,
                                            "Whatsapp" : 512314213
                                       }
    - PUT Contact by Id: http://localhost:5000/api/contact/1
    - DELETE Contact by Id: http://localhost:5000/api/contact/1
    

    ----- WeatherApp -----

1. Open \Bravi\bravi-weather in your terminal.
2. Run "npm install" to install all project dependencies.
3. Run "ng serve --o" to run the application.
4. Open chrome and paste http://localhost:4200/
