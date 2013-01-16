# GUS Gives Member Generator

This application generates a CSV file that contains sample data of people/members for the development of the GUS Gives website. GUS Gives was a portal that charities could used to collect donations while at the same time having complex analytics on member and donor information.

The data requirements for the data set is fairly complex and listed in `requirements.md`. Name and suburb data sets are supplied in the `Data` directory, while other data generation rules (e.g. incomes, phone number patterns) are embedded in the data generators (`Generators` directory). Data sets are obtained from a variety of Internet sources including the US Census Bureau, Australian Bureau of Statistics, OpenStreetMap, and Wikipedia.
