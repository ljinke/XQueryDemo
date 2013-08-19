XQueryDemo
==========

###A demo app for XQuery/XPath###


####Sample XPath:####

- /    selects the root element
- /catalog	       selects the elements under /catalog
- /catalog/cd	selects all the 'cd' elements of the catalog element
- /catalog/cd/price	selects all the price elements of all the cd elements of the catalog element
- /catalog/cd[price>10.0]	selects all the cd elements with price greater than 10.0
- starts with a slash(/)	represents an absolute path to an element
- starts with two slashes(//)	selects all elements that satisfy the criteria
- //cd	selects all cd elements in the document
- /catalog/cd/title | /catalog/cd/artist	selects all the title and artist elements of the cd elements of catalog
- //title | //artist	selects all the title and artist elements in the document
- /catalog/cd/*	selects all the child elements of all cd elements of the catalog element
- /catalog/*/price	selects all the price elements that are grandchildren of catalog
- /*/*/price	selects all price elements which have two ancestors
- //*	selects all elements in the document
- /catalog/cd[1]	selects the first cd child of catalog
- /catalog/cd[last()]	selects the last cd child of catalog
- /catalog/cd[price]	selects all the cd elements that have price
- /catalog/cd[price=10.90]	selects cd elements with the price of 10.90
- /catalog/cd[price=10.90]/price	selects all price elements with the price of 10.90
- //@country	selects all "country" attributes
- //cd[@country]	selects cd elements which have a "country" attribute
- //cd[@*]	selects cd elements which have any attribute
- //cd[@country='UK']	selects cd elements with "country" attribute equal to 'UK'

####Sample doc:####

<pre>
&lt;?xml version="1.0" encoding="ISO-8859-1"?&gt;
&lt;catalog&gt;
  &lt;cd country="USA"&gt;
    &lt;title&gt;Empire Burlesque&lt;/title&gt;
    &lt;artist&gt;Bob Dylan&lt;/artist&gt;
    &lt;price&gt;10.90&lt;/price&gt;
  &lt;/cd&gt;
  &lt;cd country="UK"&gt;
    &lt;title&gt;Hide your heart&lt;/title&gt;
    &lt;artist&gt;Bonnie Tyler&lt;/artist&gt;
    &lt;price&gt;10.0&lt;/price&gt;
  &lt;/cd&gt;
  &lt;cd country="USA"&gt;
    &lt;title&gt;Greatest Hits&lt;/title&gt;
    &lt;artist&gt;Dolly Parton&lt;/artist&gt;
    &lt;price&gt;9.90&lt;/price&gt;
  &lt;/cd&gt;
&lt;/catalog&gt;
</pre>
