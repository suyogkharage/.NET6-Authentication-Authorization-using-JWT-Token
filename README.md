
This .NET 6 WebAPI application demonstrates use of JWT token for Registration, Login and Authentication purpose.

AuthController.cs 

1 - Register User
	- Create PasswordHash using password and store it in global variable

2 - Login
	- Verify PasswordHash by computing new PasswordHash using 
		- Compute new PasswordHash using password and compare it with already stored PasswordHash
		- return true if both are same 
	- Create JWT token is both PasswordHash are same and return
	
	
If you add Authorize parameter above an ActionMethod, swagger will give you 500 error mentioning "No authenticationScheme was specified, and there was no DefaultChallengeScheme found"	

To avoid this, provide options for AddAuthentication method and use "UseAuthentication" middleware in Program.cs
Note - app.UseAuthentication() call should be placed before app.UseAuthorization();

Now you will get response as 401 on swagger since token is not being sent along with HTTPS request header

later, add options for AddSwaggerGen() method in Program.cs and then Authorize button will start displaying on top of swagger page.
Get token from login method and add it inside "Authorize" button (bearer<space><token_value>)

After authorizing it, endpoint will start giving actual response in swagger	


Roles =>

After adding Authorize(Roles ="Admin") above an action method, 
swagger will give 403 (forbidden) error since Role is not added in claim list.

Now add new claim inside CreateToken method with Admin role and by generating new token again,
endpoint will give you correct response.
