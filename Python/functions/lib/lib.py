def sortPeople(people):
	people_list = 0
	if isinstance(people, list):
		people_list = [p['lastName'] + ', ' + p['firstName'] for p in people]
		people_list = sorted(people_list)
		
	return people_list