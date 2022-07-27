Postman Collection: https://www.getpostman.com/collections/3a7c785a66d0f47349ce

- There are 5 APIs for 5 reports. All of these APIs using POST method with data to be sent in the body of the request.
- There is an extra param "returnBytes" that can be passed in the query string (can be true/false)
  + If you are calling the API from client side with javascript, leave "returnBytes" as false, the API result will be a based64 string which you can then convert to blob to allow user download. Example for this can be found in the Example.html file.
  + If you are calling the API from server side and prefer to receive the file directly instead of based64 string, leave "returnBytes" as true, the API result will be a byte array which you can use to save as an excel file on the server.