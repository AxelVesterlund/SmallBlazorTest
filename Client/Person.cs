using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
internal class Person
{
    public string firstname { get; set; }
    public int age { get; set; }
    [JsonProperty(PropertyName = "id")]
    public string id { get; set; }
    public string _rid { get; set; }
    public string _self { get; set; }
    public string _etag { get; set; }
    public string _attachments { get; set; }
    public int _ts { get; set; }
    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }

    public Person(string firstname, int age, string id = "")
    {
        this.firstname = firstname;
        this.age = age;

        if(!string.IsNullOrEmpty(id))
            this.id = id;
        else
            this.id = Guid.NewGuid().ToString();
    }
}
