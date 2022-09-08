# LSM
A well reputed company's Coding Case - Full-stack Developer
Company's LSM software has a search function which helps users to find and navigate to entities (eg. smart locks). Entities have some amount of own searchable fields and might have some amount of transitive searchable fields. Fields are more or less significant for the user and therefore most relevant search results should be placed first.

The similar situation with the full match and the partial match, the full match should be considered 10x more relevant than partial match for both own and transitive fields.

# Task Definition
You need to implement prototype of search functionality for the data stored in the file [sv_lsm_data.json](https://github.com/tahsildari/LSM/blob/master/LSM/Data/sv_lsm_data.json), it means that you have to:

implement search logic in the backend in order that most relevant search results go first
implement API for processing search requests
create simple website with search field and results area; integrate it with API
[optionally] host your prototype on cloud platform (for example heroku)
You are free to use any framework, any platform and any development environment.

Have fun!

# Documentation
The following entities definition contains information about weights for search engine. The weights for own properties defined as W=<number>. The weights for transitive properties defined as Wt(<name>)=<number>.

For example Lock has following weight definition for property Lock.buildingId

  buildingId : UUID # Wt(name)=8 ...
it means that for search input ‘head’ the building with name ‘Head office’ will get own weight 9 (see below) and will give weight 8 for all locks within the building.

DataFile is a root object in json file with data.

Note: the results with maximum sum of weights are the most relevant

```json
DataFile := {
  buildings      : arrayOf Building
  locks          : arrayOf Lock

  groups         : arrayOf Group
  media          : arrayOf Medium
}

Building := {
  id            : UUID
  shortCut      : String       # W=7
  name          : String       # W=9
  description   : String       # W=5
}

Lock := {
  id            : UUID
  buildingId    : UUID         # Wt(name)=8, Wt(shortCut)=5, Wt(description)=0
  type          : LockType     # W=3
  name          : String       # W=10
  serialNumber  : String       # W=8
  floor         : String       # W=6
  roomNumber    : String       # W=6
  description   : String       # W=6
}

Group := {
  id            : UUID
  name          : String       # W=9
  description   : String       # W=5
}

Medium := {
  id            : UUID
  groupId       : UUID         # Wt(name)=8, Wt(description)=0
  type          : MediumType   # W=3
  owner         : String       # W=10
  serialNumber  : String       # W=8
  description   : String       # W=6
}
```
