
# Collections

## GET /collections/{folderid}
Fetch collection folder contents

## GET /collections/folders
Fetch collection folders

# Deviation

## GET /deviation/{deviationid}
Fetch a deviation

## GET /deviation/download/{deviationid}
Get the original file download (if allowed)

## GET /deviation/metadata
Fetch deviation metadata for a set of deviations

# Gallery

## GET /gallery/{folderid}
Fetch gallery folder contents

## GET /gallery/all
Get the "all" view of a users gallery

## GET /gallery/folders
Fetch gallery folders

# User

## GET /user/friends/{username}
Get the users list of friends
This is the list of users that the `{username}` is watching.

### Useful Fields
* has_more
* next_offset
* results
    * .user
        * .userid
        * .username

## GET /user/profile/{username}
Get user profile information

### Useful Fields
* tagline
* bio
* collections (ext_collections)
    * folderid
    * name
* galleries (ext_galleries)
    * folderid
    * parent
    * name