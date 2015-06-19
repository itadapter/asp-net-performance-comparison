# asp-net-performance-comparison
This is an ASP.NET counterpart to <a href="https://github.com/nik-z/nfx-wave-performance-comparison/">NFX.Wave performance test application</a>. It is created to make their mutual performance comparison possible and covers a similar set of performance tests:
 * A simple string echo
 * A JSON packed echo responce
 * A dynamic JSON representation of data object
 * A dynamic page rendered by templete engine for data object
 * A random payload of given length dynamically generated via MVC pipeline
 
URLs for tests:

* &lt;site root&gt;/Backend/RandomPerson - returns a JSON representation of randomly generated Person object
* &lt;site root&gt;/Backend/RandomPayload?length=&lt;integer number&gt; - returns a random string of specified length
* &lt;site root&gt;/Backend/Echo?data=&lt;any string&gt; - returns a simple string echo of string that was sent as the parameter
* &lt;site root&gt;/Test/RandomPerson   - returns a page with CSS styles and formatting with a representation of randomly generated Person object
* &lt;site root&gt;/Test/RandomPersonSimple   - returns a very minimalistic page with a representation of randomly generated Person object
