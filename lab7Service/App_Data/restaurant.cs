﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// 此源代码由 xsd 自动生成, Version=4.8.3928.0。
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.algonquincollege.com/cst8259/labs", IsNullable = false)]
public partial class Address
{

    private string streetField;

    private string cityField;

    private AddressProvince provinceField;

    private string zipField;

    /// <remarks/>
    public string Street
    {
        get
        {
            return this.streetField;
        }
        set
        {
            this.streetField = value;
        }
    }

    /// <remarks/>
    public string City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public AddressProvince Province
    {
        get
        {
            return this.provinceField;
        }
        set
        {
            this.provinceField = value;
        }
    }

    /// <remarks/>
    public string Zip
    {
        get
        {
            return this.zipField;
        }
        set
        {
            this.zipField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
public enum AddressProvince
{

    /// <remarks/>
    AB,

    /// <remarks/>
    BC,

    /// <remarks/>
    MB,

    /// <remarks/>
    NB,

    /// <remarks/>
    NL,

    /// <remarks/>
    NS,

    /// <remarks/>
    ON,

    /// <remarks/>
    PE,

    /// <remarks/>
    QC,

    /// <remarks/>
    SK,

    /// <remarks/>
    NT,

    /// <remarks/>
    NU,

    /// <remarks/>
    YT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.algonquincollege.com/cst8259/labs", IsNullable = false)]
public partial class Appetizer
{

    private string nameField;

    private string descriptionField;

    private decimal priceField;

    private string servingSizeField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public decimal Price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string servingSize
    {
        get
        {
            return this.servingSizeField;
        }
        set
        {
            this.servingSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.algonquincollege.com/cst8259/labs", IsNullable = false)]
public partial class Entree
{

    private string nameField;

    private string descriptionField;

    private decimal priceField;

    private string isGlutenFriendlyField;

    private string isVeganFriendlyField;

    public Entree()
    {
        this.isGlutenFriendlyField = "False";
        this.isVeganFriendlyField = "False";
    }

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public decimal Price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("False")]
    public string isGlutenFriendly
    {
        get
        {
            return this.isGlutenFriendlyField;
        }
        set
        {
            this.isGlutenFriendlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("False")]
    public string isVeganFriendly
    {
        get
        {
            return this.isVeganFriendlyField;
        }
        set
        {
            this.isVeganFriendlyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.algonquincollege.com/cst8259/labs", IsNullable = false)]
public partial class Restaurants
{

    private RestaurantsRestaurant[] restaurantField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Restaurant")]
    public RestaurantsRestaurant[] Restaurant
    {
        get
        {
            return this.restaurantField;
        }
        set
        {
            this.restaurantField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
public partial class RestaurantsRestaurant
{

    private string nameField;

    private string websiteField;

    private RestaurantsRestaurantLogo logoField;

    private Address addressField;

    private string phoneField;

    private byte ratingField;

    private string priceField;

    private RestaurantsRestaurantDate dateField;

    private RestaurantsRestaurantReviewer reviewerField;

    private string summaryField;

    private Appetizer[] appetizersField;

    private Entree[] entreesField;

    private string typeField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }

    /// <remarks/>
    public RestaurantsRestaurantLogo Logo
    {
        get
        {
            return this.logoField;
        }
        set
        {
            this.logoField = value;
        }
    }

    /// <remarks/>
    public Address Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public string Phone
    {
        get
        {
            return this.phoneField;
        }
        set
        {
            this.phoneField = value;
        }
    }

    /// <remarks/>
    public decimal Rating
    {
        get
        {
            return this.ratingField;
        }
        set
        {
            this.ratingField = (byte)value;
        }
    }

    /// <remarks/>
    public string Price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <remarks/>
    public RestaurantsRestaurantDate Date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    public RestaurantsRestaurantReviewer Reviewer
    {
        get
        {
            return this.reviewerField;
        }
        set
        {
            this.reviewerField = value;
        }
    }

    /// <remarks/>
    public string Summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Appetizer", IsNullable = false)]
    public Appetizer[] Appetizers
    {
        get
        {
            return this.appetizersField;
        }
        set
        {
            this.appetizersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Entree", IsNullable = false)]
    public Entree[] Entrees
    {
        get
        {
            return this.entreesField;
        }
        set
        {
            this.entreesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
public partial class RestaurantsRestaurantLogo
{

    private RestaurantsRestaurantLogoHeight heightField;

    private RestaurantsRestaurantLogoWidth widthField;

    private string linkField;

    /// <remarks/>
    public RestaurantsRestaurantLogoHeight Height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    public RestaurantsRestaurantLogoWidth Width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public string Link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
public partial class RestaurantsRestaurantLogoHeight
{

    private string unitField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
public partial class RestaurantsRestaurantLogoWidth
{

    private string unitField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
public partial class RestaurantsRestaurantDate
{

    private string monthField;

    private byte dayField;

    private ushort yearField;

    /// <remarks/>
    public string Month
    {
        get
        {
            return this.monthField;
        }
        set
        {
            this.monthField = value;
        }
    }

    /// <remarks/>
    public byte Day
    {
        get
        {
            return this.dayField;
        }
        set
        {
            this.dayField = value;
        }
    }

    /// <remarks/>
    public ushort Year
    {
        get
        {
            return this.yearField;
        }
        set
        {
            this.yearField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.algonquincollege.com/cst8259/labs")]
public partial class RestaurantsRestaurantReviewer
{

    private string firstNameField;

    private string lastNameField;

    /// <remarks/>
    public string firstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }

    /// <remarks/>
    public string lastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }
}
