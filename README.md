# PatientTrac

PatientTrac allows doctors to search for patients inside the database and view any or all medications the patient is currently taking. Doctor can choose Patient tab inside Navbar to
display a list of their current patients. Doctors can add medications that aren't currently in the database from the Medications Tab in the navbar. If a patient is no longer seeing the
doctor, they can be deleted by the doctor from their current patient list. The patients can not be deleted from the database. Medications assigned to a patient can not deleted from the
patients profile. STOP DOCTOR SHOPPING!

## Getting Started

1. Clone down my repo

2. type start PatientTrac.sln

3. This will open the file inside Visual Studio

4. Press IIS Express play button to start up the server

5. A browser window will automatically open and display my site once the project builds inside Visual Studio

## LogIn/Register
1.  Log in with the seeded data and doctor using the credentials below. 
	- Email: admin@admin.com
	- Password: Admin123!

2. Register for a new doctor by clicking on the Register Tab inside the navbar. You will need to include all information the form ask for.

## Patient

1. Click on the Patient tab inside navbar to display a list of patients belonging to the doctor that is currently logged in.

2. You can click "Create New" link to add a new patient. (First Name, Last Name, Street Address, Phone Number, Age, and Sex)

3. To add Medications to a patient's profile, click on the "Edit" link next to the patients information. When the edit form populates, there will be a button "Add Medications" toward
the bottom. Click this button and fill out information

4. Add Medications form will need to be completed with Medication Name(select List), Currently Taking(checkbox), Start Date, Stop Date(can be left blank), and Dosage in milligrams.

5. Click on the details link to show information about the patient as well as any medications that have been added to their profile. This information Can Not be deleted.

6. If a patient is no longer seeing the current logged in doctor, you can delete them from the list ONLY. They will still be inside the database.

## Medication

1. Click on the Patient tab inside navbar to display a list of medications

2. You can click "Create New" link to add a new medication. (Name and Type)

## Search

1. Doctors can search for a patient even if they do not belong to their facility or current list.

2. Click on the name of the patient to view the details in order to confirm you have selected the correct patient and show if and when they have been given any and all medications.