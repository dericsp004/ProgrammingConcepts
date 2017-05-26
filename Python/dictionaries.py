
# Store keys in list of tuples
data_keys = [("first-name", "last-name", "address", "city", "state", "zip-code", "phone-numbers"),("cell", "home", "work")]

# Seed Data
contacts = { "Plummer" : 
				{ data_keys[0][0]: "Deric" 
				, data_keys[0][1]: "Plummer" 
				, data_keys[0][2]: "123 Starfire Ave" 
				, data_keys[0][3]: "Corona" 
				, data_keys[0][4]: "CA"
				, data_keys[0][5]: "92879"
				, data_keys[0][6]: 
					{ data_keys[1][0]: "951-111-4444" 
			  		, data_keys[1][1]: "951-222-5555" 
			  		, data_keys[1][2]: "951-333-6666"}
				}
			}


# Start Console
print "\nWelcome to the Contact Book Application"

answer = str(1)
while answer != str(3):
	print """\n1) Look up a Contact
2) Enter a new Contact
3) Exit"""
	answer = raw_input("\nWhat would you like to do? ")


	# Prompt user for a last name (key)
	if answer == str(1):	
		key = raw_input("Whats the person's last name whose contact info you want to see? ")

		if key in contacts.keys():
			print "\n\tFirst Name: " + contacts[key][data_keys[0][0]]
			print "\tLast Name: " + contacts[key][data_keys[0][1]]
			print "\tAddress: " + contacts[key][data_keys[0][2]]
			print "\tCity: " + contacts[key][data_keys[0][3]]
			print "\tState: " + contacts[key][data_keys[0][4]]
			print "\tZip-Code: " + contacts[key][data_keys[0][5]]
			print "\tPhone Numbers: " 
			print "\t\tCell: " + contacts[key][data_keys[0][6]][data_keys[1][0]]
			print "\t\tHome: " + contacts[key][data_keys[0][6]][data_keys[1][1]]
			print "\t\tWork: " + contacts[key][data_keys[0][6]][data_keys[1][2]]
		else:
			print "Error: " + key + " was not found."

	# Get Contact Data
	if answer == str(2):
		print "\nEnter contact data (if data doesnt exist enter 'N/A'):"
		last_name = raw_input("\tEnter last name: ")
		first_name = raw_input("\tEnter first name: ")
		address = raw_input("\tEnter address: ")
		city = raw_input("\tEnter city: ")
		state = raw_input("\tEnter state: ")
		zip_code = raw_input("\tEnter zip: ")

		# Get Phone Numbers
		phone_numbers = {}
		for i in range(0, 3):
			phone_number = raw_input("\tEnter " + data_keys[1][i] + " number: ")
			#Add Phone Number to Dictionary
			phone_numbers[data_keys[1][i]] = phone_number

		# Add data in contacts dictionary
		contacts[last_name] = {data_keys[0][0]: first_name
					, data_keys[0][1] : last_name
					, data_keys[0][2] : address
					, data_keys[0][3] : city
					, data_keys[0][4] : state
					, data_keys[0][5] : zip_code
					, data_keys[0][6] : phone_numbers }

		print "Contact was Saved"


print "Contact book exited"

