#!/usr/bin/python
from lib import sortPeople

people = [{'firstName': "Bruce", 'lastName': "Wayne"}
		 ,{'firstName': "James", 'lastName': "Gordon"}
		 ,{'firstName': "Dick", 'lastName': "Grayson"}
		 ,{'firstName': "Alfred", 'lastName': "Pennyworth"}
		 ,{'firstName': "Ellen", 'lastName': "Yin"}
		 ,{'firstName': "Barbara", 'lastName': "Gordon"}]


list_people = sortPeople(people)

for i, e in enumerate(list_people):
	print "[" + str(i) + "][" + list_people[i] + "]"
