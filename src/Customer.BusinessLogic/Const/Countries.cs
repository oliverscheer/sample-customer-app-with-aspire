﻿namespace Customer.DatabaseLogic.Const
{
    public static class Countries
    {
        public class Country
        {
            public Guid Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Code { get; set; } = string.Empty;
        }

        public static List<Country> All = [
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Afghanistan", Code = "AF" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Albania", Code = "AL" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Algeria", Code = "DZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Andorra", Code = "AD" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Angola", Code = "AO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Antigua and Barbuda", Code = "AG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Argentina", Code = "AR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Armenia", Code = "AM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Australia", Code = "AU" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Austria", Code = "AT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Azerbaijan", Code = "AZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Bahamas", Code = "BS" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Bahrain", Code = "BH" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "Bangladesh", Code = "BD" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Name = "Barbados", Code = "BB" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000016"), Name = "Belarus", Code = "BY" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000017"), Name = "Belgium", Code = "BE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000018"), Name = "Belize", Code = "BZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000019"), Name = "Benin", Code = "BJ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000020"), Name = "Bhutan", Code = "BT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000021"), Name = "Bolivia", Code = "BO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000022"), Name = "Bosnia and Herzegovina", Code = "BA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000023"), Name = "Botswana", Code = "BW" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000024"), Name = "Brazil", Code = "BR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000025"), Name = "Brunei", Code = "BN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000026"), Name = "Bulgaria", Code = "BG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000027"), Name = "Burkina Faso", Code = "BF" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000028"), Name = "Burundi", Code = "BI" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000029"), Name = "Cabo Verde", Code = "CV" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000030"), Name = "Cambodia", Code = "KH" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000031"), Name = "Cameroon", Code = "CM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000032"), Name = "Canada", Code = "CA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000033"), Name = "Central African Republic", Code = "CF" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000034"), Name = "Chad", Code = "TD" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000035"), Name = "Chile", Code = "CL" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000036"), Name = "China", Code = "CN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000037"), Name = "Colombia", Code = "CO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000038"), Name = "Comoros", Code = "KM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000039"), Name = "Congo, Democratic Republic of the", Code = "CD" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000040"), Name = "Congo, Republic of the", Code = "CG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000041"), Name = "Costa Rica", Code = "CR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000042"), Name = "Croatia", Code = "HR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000043"), Name = "Cuba", Code = "CU" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000044"), Name = "Cyprus", Code = "CY" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000045"), Name = "Czech Republic", Code = "CZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000046"), Name = "Denmark", Code = "DK" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000047"), Name = "Djibouti", Code = "DJ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000048"), Name = "Dominica", Code = "DM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000049"), Name = "Dominican Republic", Code = "DO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000050"), Name = "Ecuador", Code = "EC" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000051"), Name = "Egypt", Code = "EG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000052"), Name = "El Salvador", Code = "SV" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000053"), Name = "Equatorial Guinea", Code = "GQ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000054"), Name = "Eritrea", Code = "ER" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000055"), Name = "Estonia", Code = "EE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000056"), Name = "Eswatini", Code = "SZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000057"), Name = "Ethiopia", Code = "ET" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000058"), Name = "Fiji", Code = "FJ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000059"), Name = "Finland", Code = "FI" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000060"), Name = "France", Code = "FR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000061"), Name = "Gabon", Code = "GA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000062"), Name = "Gambia", Code = "GM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000063"), Name = "Georgia", Code = "GE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000064"), Name = "Germany", Code = "DE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000065"), Name = "Ghana", Code = "GH" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000066"), Name = "Greece", Code = "GR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000067"), Name = "Grenada", Code = "GD" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000068"), Name = "Guatemala", Code = "GT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000069"), Name = "Guinea", Code = "GN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000070"), Name = "Guinea-Bissau", Code = "GW" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000071"), Name = "Guyana", Code = "GY" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000072"), Name = "Haiti", Code = "HT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000073"), Name = "Honduras", Code = "HN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000074"), Name = "Hungary", Code = "HU" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000075"), Name = "Iceland", Code = "IS" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000076"), Name = "India", Code = "IN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000077"), Name = "Indonesia", Code = "ID" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000078"), Name = "Iran", Code = "IR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000079"), Name = "Iraq", Code = "IQ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000080"), Name = "Ireland", Code = "IE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000081"), Name = "Israel", Code = "IL" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000082"), Name = "Italy", Code = "IT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000083"), Name = "Jamaica", Code = "JM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000084"), Name = "Japan", Code = "JP" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000085"), Name = "Jordan", Code = "JO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000086"), Name = "Kazakhstan", Code = "KZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000087"), Name = "Kenya", Code = "KE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000088"), Name = "Kiribati", Code = "KI" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000089"), Name = "Korea, North", Code = "KP" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000090"), Name = "Korea, South", Code = "KR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000091"), Name = "Kosovo", Code = "XK" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000092"), Name = "Kuwait", Code = "KW" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000093"), Name = "Kyrgyzstan", Code = "KG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000094"), Name = "Laos", Code = "LA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000095"), Name = "Latvia", Code = "LV" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000096"), Name = "Lebanon", Code = "LB" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000097"), Name = "Lesotho", Code = "LS" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000098"), Name = "Liberia", Code = "LR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000099"), Name = "Libya", Code = "LY" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000100"), Name = "Liechtenstein", Code = "LI" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000101"), Name = "Lithuania", Code = "LT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000102"), Name = "Luxembourg", Code = "LU" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000103"), Name = "Madagascar", Code = "MG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000104"), Name = "Malawi", Code = "MW" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000105"), Name = "Malaysia", Code = "MY" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000106"), Name = "Maldives", Code = "MV" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000107"), Name = "Mali", Code = "ML" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000108"), Name = "Malta", Code = "MT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000109"), Name = "Marshall Islands", Code = "MH" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000110"), Name = "Mauritania", Code = "MR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000111"), Name = "Mauritius", Code = "MU" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000112"), Name = "Mexico", Code = "MX" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000113"), Name = "Micronesia", Code = "FM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000114"), Name = "Moldova", Code = "MD" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000115"), Name = "Monaco", Code = "MC" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000116"), Name = "Mongolia", Code = "MN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000117"), Name = "Montenegro", Code = "ME" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000118"), Name = "Morocco", Code = "MA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000119"), Name = "Mozambique", Code = "MZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000120"), Name = "Myanmar", Code = "MM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000121"), Name = "Namibia", Code = "NA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000122"), Name = "Nauru", Code = "NR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000123"), Name = "Nepal", Code = "NP" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000124"), Name = "Netherlands", Code = "NL" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000125"), Name = "New Zealand", Code = "NZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000126"), Name = "Nicaragua", Code = "NI" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000127"), Name = "Niger", Code = "NE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000128"), Name = "Nigeria", Code = "NG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000129"), Name = "North Macedonia", Code = "MK" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000130"), Name = "Norway", Code = "NO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000131"), Name = "Oman", Code = "OM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000132"), Name = "Pakistan", Code = "PK" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000133"), Name = "Palau", Code = "PW" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000134"), Name = "Palestine", Code = "PS" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000135"), Name = "Panama", Code = "PA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000136"), Name = "Papua New Guinea", Code = "PG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000137"), Name = "Paraguay", Code = "PY" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000138"), Name = "Peru", Code = "PE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000139"), Name = "Philippines", Code = "PH" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000140"), Name = "Poland", Code = "PL" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000141"), Name = "Portugal", Code = "PT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000142"), Name = "Qatar", Code = "QA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000143"), Name = "Romania", Code = "RO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000144"), Name = "Russia", Code = "RU" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000145"), Name = "Rwanda", Code = "RW" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000146"), Name = "Saint Kitts and Nevis", Code = "KN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000147"), Name = "Saint Lucia", Code = "LC" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000148"), Name = "Saint Vincent and the Grenadines", Code = "VC" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000149"), Name = "Samoa", Code = "WS" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000150"), Name = "San Marino", Code = "SM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000151"), Name = "Sao Tome and Principe", Code = "ST" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000152"), Name = "Saudi Arabia", Code = "SA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000153"), Name = "Senegal", Code = "SN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000154"), Name = "Serbia", Code = "RS" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000155"), Name = "Seychelles", Code = "SC" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000156"), Name = "Sierra Leone", Code = "SL" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000157"), Name = "Singapore", Code = "SG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000158"), Name = "Slovakia", Code = "SK" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000159"), Name = "Slovenia", Code = "SI" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000160"), Name = "Solomon Islands", Code = "SB" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000161"), Name = "Somalia", Code = "SO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000162"), Name = "South Africa", Code = "ZA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000163"), Name = "South Sudan", Code = "SS" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000164"), Name = "Spain", Code = "ES" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000165"), Name = "Sri Lanka", Code = "LK" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000166"), Name = "Sudan", Code = "SD" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000167"), Name = "Suriname", Code = "SR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000168"), Name = "Sweden", Code = "SE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000169"), Name = "Switzerland", Code = "CH" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000170"), Name = "Syria", Code = "SY" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000171"), Name = "Taiwan", Code = "TW" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000172"), Name = "Tajikistan", Code = "TJ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000173"), Name = "Tanzania", Code = "TZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000174"), Name = "Thailand", Code = "TH" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000175"), Name = "Timor-Leste", Code = "TL" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000176"), Name = "Togo", Code = "TG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000177"), Name = "Tonga", Code = "TO" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000178"), Name = "Trinidad and Tobago", Code = "TT" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000179"), Name = "Tunisia", Code = "TN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000180"), Name = "Turkey", Code = "TR" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000181"), Name = "Turkmenistan", Code = "TM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000182"), Name = "Tuvalu", Code = "TV" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000183"), Name = "Uganda", Code = "UG" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000184"), Name = "Ukraine", Code = "UA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000185"), Name = "United Arab Emirates", Code = "AE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000186"), Name = "United Kingdom", Code = "GB" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000187"), Name = "United States", Code = "US" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000189"), Name = "Uruguay", Code = "UY" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000190"), Name = "Uzbekistan", Code = "UZ" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000191"), Name = "Vanuatu", Code = "VU" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000192"), Name = "Vatican City", Code = "VA" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000193"), Name = "Venezuela", Code = "VE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000194"), Name = "Vietnam", Code = "VN" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000195"), Name = "Yemen", Code = "YE" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000196"), Name = "Zambia", Code = "ZM" },
            new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000197"), Name = "Zimbabwe", Code = "ZW"}
            ];
    }
}
