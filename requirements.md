# GUS Gives Member Generator Requirements

_Note: these requirements are incomplete and are superseded by the rules used in the application._

Generate data for 50,000 members.

## Gender
* Female (56%)
* Male (44%)

## Name
* [US census name distribution](http://www.census.gov/genealogy/names/names_files.html)

## Age
* Male
    * 16-25 (%)
    * 26-35 (%)
    * 36-45 (%)
    * 46-55 (%)
    * 56-65 (%)
    * 65+ (%)
    * Null (%)
* Female
    * 16-25 (%)
    * 26-35 (%)
    * 36-45 (%)
    * 46-55 (%)
    * 56-65 (%)
    * 65+ (%)
    * Null (%)

## Country
* Australia (97%)
    * QLD (60%)
    * NSW (16%)
    * VIC (12%)
    * WA (5%)
    * SA (4%)
    * TAS (1%)
    * ACT (1%)
    * NT (1%)
    * ABS population per state
* GB (2%)
    * London (81%)
    * Birmingham (11%)
    * Leeds (8%)
* NZ (1%)
    * Auckland (64%)
    * Christchurch (18%)
    * Wellington (18%)

## Unit / House Number
* Australia
    * Street number
        * 1-100
    * With unit number
        * Ages
            * 16-25 (20%)
            * 26-35 (30%)
            * 36-45 (10%)
            * 46-55 (10%)
            * 56-65 (10%)
            * 65+ (25%)
        * Unit numbers
            * 1-6 (50%)
            * 7-12 (25%)
            * 13-18 (15%)
            * 19-24 (10%)
* GB
* NZ
* Null (%)

## Street Address
* Australia
    * [Australian streets and suburbs](http://www.osmaustralia.org/downloads.php)
* GB
    * [GB streets and suburbs](http://download.geofabrik.de/osm/europe/great_britain/england.osm.bz2)
* NZ
    * [NZ streets and suburbs](http://www.osmaustralia.org/osmnzextract.php)
* Null (%)

## Suburb/Post Code
* Australia
    * [Australian streets and suburbs](http://www.osmaustralia.org/downloads.php)
    * [Australian postcodes](http://auspost.com.au/products-and-services/download-postcode-data.html)
* GB
* NZ
    * [Auckland suburbs](http://en.wikipedia.org/wiki/Category:Suburbs_of_Auckland)
    * [Christchurch suburbs](http://en.wikipedia.org/wiki/Category:Suburbs_of_Christchurch)
    * [Wellington suburbs](http://en.wikipedia.org/wiki/Category:Suburbs_of_Wellington)
    * [NZ streets and suburbs](http://www.osmaustralia.org/osmnzextract.php)
    * [NZ post codes](http://www.noodles.net.nz/2007/09/14/new-zealand-postcode-database-v2/)
* Null (%)

## Email
* User name
    * First name/last name (70%)
    * First initial/last name (30%)
    * Append numbers starting at 1 if collision
* Domain name
    * Australia
        * @yahoo.com (15%)
        * @yahoo.com.au (10%)
        * @hotmail.com (25%)
        * @gmail.com (15%)
        * @bigpond.net (10%)
        * @iinet.net.au (10%)
        * @optusnet.net.au (8%)
        * @tpg.com.au (4%)
        * @internode.on.net (3%)
    * GB and NZ
        * @yahoo.com (38%)
        * @hotmail.com (38%)
        * @gmail.com (24%)

## Home Phone
* Australia
    * Random digits apart from area code
    * [Telephone prefixes for suburbs](http://www.telstrawholesale.com/products/docs/access_broadband_adsl_en_ex.xls)
* GB
    * London
        * +44 203 (20%)
        * +44 207 (40%)
        * +44 208 (40%)
        * [7 additional random digits](http://en.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom#020_for_London)
    * Birmingham
        * +44 121
        * [7 additional random digits](http://en.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom#Geographic_numbering)
    * Leeds
        * +44 113
        * [7 additional random digits](http://en.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom#Geographic_numbering)
* NZ
    * Auckland
        * +64 944 (16%)
        * +64 947 (16%)
        * +64 948 (16%)
        * +64 95 (16%)
        * +64 96 (16%)
        * +64 98 (16%)
    * Christchurch
        * +64 33 (20%)
        * +64 394 (20%)
        * +64 396 (20%)
        * +64 397 (20%)
        * +64 398 (20%)
    * Wellington
        * +64 423 (14%)
        * +64 429 (14%)
        * +64 43 (14%)
        * +64 44 (14%)
        * +64 45 (14%)
        * +64 48 (14%)
        * +64 49 (14%)
    * [Total of 8 digits](http://en.wikipedia.org/wiki/Telephone_numbers_in_New_Zealand#Landlines)
* Null (%)

## Mobile Phone
* Australia
    * Random digits apart from area code
    * [Mobile prefixes](http://en.wikipedia.org/wiki/Telephone_numbers_in_Australia#Mobile_phone_numbers_.2804.29)
* GB
    * +44 74 (12%)
    * +44 75 (13%)
    * +44 77 (25%)
    * +44 78 (25%)
    * +44 79 (25%)
    * [8 additional random digits](http://en.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom#Overview)
* NZ
    * +64 21 (30%)
    * +64 22 (20%)
    * +64 27 (40%)
    * +64 29 (10%)
    * [4 additional random digits](http://en.wikipedia.org/wiki/Telephone_numbers_in_New_Zealand#Mobile_Phones)
* Null (%)

## Membership Status
* Free (%)
* Paying (%)
    * Optional Extras Y (%)
    * Optional Extras N (%)

## Income Range
* <25,000
* 25,001-40,000
* 40,001-55,000
* 55,001-70,000
* 70,001-85,000
* 85,001-100,000
* 100,001-120,000
* 120,001-140,000
* 140,001+
* Null (%)
* [ABS Stats](http://www.abs.gov.au/AUSSTATS/abs@.nsf/DetailsPage/6523.02009-10?OpenDocument)

## Number Of People In Home
* Adults (18+)
    * 1 (30%)
    * 2 (55%)
    * 3 (10%)
    * 4 (5%)
* Teenagers (13-17)
    * 0 (40%)
    * 1 (30%)
    * 2 (20%)
    * 3 (10%)
* Young Children (3-12)
    * 0 (40%)
    * 1 (30%)
    * 2 (20%)
    * 3 (10%)
* Babies/Toddlers (0-2)
    * 0 (40%)
    * 1 (30%)
    * 2 (20%)
    * 3 (10%)

## Adult Members
* Working Full Time (%)
* Working Part Time (%)
* Retired (%)
* Unemployed (%)
* Student (%)
* Null (%)

## Property Owner
* Yes (%)
* No (%)
* Null (%)

## Property Upgrades
* Yes (%)
* No (%)
* Null (%)

## Property Upgrade Area
* Area
    * Kitchen (%)
    * Bathroom (%)
    * Bedroom (%)
    * Living Room (%)
    * Garden/Landscaping (%)
    * Pool (%)
    * Other
* Multiples
    * 1 (50%)
    * 2 (25%)
    * 3 (12.5%)
    * 4 (6.25%)
    * 5 (3.125%)
    * 6 (3.125%)

## Electronic Purchases
* Yes (%)
* No (%)
* Null (%)

## Electronic Purchase
* Item
    * Television (%)
    * Home Theatre (%)
    * Music System (%)
    * Computer (%)
    * Dishwasher (%)
    * Fridge (%)
    * Washing Machine (%)
    * Vacuum Cleaner (%)
    * Other
* Multiples
    * 1 (50%)
    * 2 (25%)
    * 3 (12.5%)
    * 4 (6.25%)
    * 5 (3.125%)
    * 6 (1.5625%)
    * 7 (0.78125%)
    * 8 (0.78125%)
