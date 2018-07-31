# HomeServicesProgram
Program displays Job description, time in hours to complete the Job, per-hour rate charged for the Job, and total fee for the Job. Two Jobs can be added

 - a Job class for Harold’s Home Services. The class contains four data fields,
 - the class ncludes properties to get and set each field except the total fee—that field is read-only, and its value is calculated each time either the hourly fee or the number of hours is set,
 - the + operator is overloaded so that two Jobs can be added,
 - the sum of two Jobs is a new Job containing the descriptions of both original Jobs (joined by “and”), the sum of the time in hours for the original Jobs
   and the average of the hourly rate for the original Jobs
