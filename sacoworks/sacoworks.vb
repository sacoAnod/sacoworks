'Class: sacoworks
'Current version: V1.0 beta
'Descritpion:
'This class file is for working with solidworks 3D cad modelling software.
'=========================
'Precondtions:
'   a filename and location is required
'   a variable name is required
'   a variable for the value is required


'import solidworks interop

Public Class sacoworks

    'decalre the variables for starting up and setting to work with solidworks files

    'function: alter_variables
    'Descritpion:
    'This function opens the given file and alters any variables that the user has requested to be changed

    'start of function
    '   declare variables

    '   create solidworks object
    '   set the solidworks file top be opened which uses the file_name variable
    '   set the variable to access the solidworks equation manager

    '   set the visibility of solidworks

    'set the counter to 0
    'check to see if the counter matches the number of equations (counter and equation count should match zero) if do not match go to next variable
    '   set the variable to get the equation count
    '   set the variable to the current equation name to the left of the = sign
    '   set the variable for the equation name, call the function strip in stringmanipuation class to remove the ""
    '   set the variable to the current equation value to the right of the = sign
    '   set the variable for the equation value, call the function strip in stringmanipuation class to remove the ""
    '   if the equation name variable matches the actual global variable name then
    '       set the equation value to the user inputted value
    '   end if
    'next variable if equation count is not zero

    'release all objects
    'end of function


End Class
