# JWTWebAPI

This application demonstrates use of JWT token for Registration, Login and Authentication purpose.

AuthController.cs 

1 - Register User
	- Create PasswordHash using password and store it in global variable

2 - Login
	- Verify PasswordHash by computing new PasswordHash using 
		- Compute new PasswordHash using password and compare it with already stored PasswordHash
		- return true if both are same 
	- Create JWT token is both PasswordHash are same and return
	