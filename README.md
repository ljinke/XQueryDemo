XQueryDemo
==========

A demo app fro XQuery/XPath

Sample doc:

<?xml version="1.0" encoding="ISO-8859-1"?>
<catalog>
  <cd country="USA">
    <title>Empire Burlesque</title>
    <artist>Bob Dylan</artist>
    <price>10.90</price>
  </cd>
  <cd country="UK">
    <title>Hide your heart</title>
    <artist>Bonnie Tyler</artist>
    <price>10.0</price>
  </cd>
  <cd country="USA">
    <title>Greatest Hits</title>
    <artist>Dolly Parton</artist>
    <price>9.90</price>
  </cd>
</catalog>

XPath:

/    selects the root element
/catalog	       selects the elements under /catalog
/catalog/cd	selects all the 'cd' elements of the catalog element
/catalog/cd/price	selects all the price elements of all the cd elements of the catalog element
/catalog/cd[price>10.0]	selects all the cd elements with price greater than 10.0
starts with a slash(/)	represents an absolute path to an element
starts with two slashes(//)	selects all elements that satisfy the criteria
//cd	selects all cd elements in the document
/catalog/cd/title | /catalog/cd/artist	selects all the title and artist elements of the cd elements of catalog
//title | //artist	selects all the title and artist elements in the document
/catalog/cd/*	selects all the child elements of all cd elements of the catalog element
/catalog/*/price	selects all the price elements that are grandchildren of catalog
/*/*/price	selects all price elements which have two ancestors
//*	selects all elements in the document
/catalog/cd[1]	selects the first cd child of catalog
/catalog/cd[last()]	selects the last cd child of catalog
/catalog/cd[price]	selects all the cd elements that have price
/catalog/cd[price=10.90]	selects cd elements with the price of 10.90
/catalog/cd[price=10.90]/price	selects all price elements with the price of 10.90
//@country	selects all "country" attributes
//cd[@country]	selects cd elements which have a "country" attribute
//cd[@*]	selects cd elements which have any attribute
//cd[@country='UK']	selects cd elements with "country" attribute equal to 'UK'
