Testing
=======

Most packages have up to four common sets of tests. A package called
`Foo` might have:

- `Foo.Tests`: unit tests. These should run quickly, in most cases without
  an internet connection being required.
- `Foo.IntegrationTests`: integration tests. These check that our
  packages work correctly with the real API.
- `Foo.Snippets`: documentation snippets, written and executed as
  tests. These often double up as integration tests. (If a snippet can
  test everything you need to know about a call, there's no point in
  also having an integration test.) For gRPC APIs, this project
  contains autogenerated as well as handwritten code; the
  autogenerated code is only used for documentation.
- `Foo.SmokeTests`: autogenerated tests that ensure we can at least
  contact the relevant API.

The test types other than unit tests require:

- An internet connection
- A Google Cloud Platform project
- Billing enabled
- The APIs you're testing enabled
- A service account with appropriate access
- Common environment variables set as described below
- Per-API configuration as shown later, in some cases

**Running these tests can cost you money. They execute against
paid-for Google services.** They can also produce significant chunks of
network traffic - particularly some of the integration tests. You're
not recommended to run them against a mobile internet connection
unless you're sure you know what you're doing.

**These tests could destroy data in the projects they run in, or
leave test data afterwards.** Most tests create data in a
well-partitioned way and clean up after themselves, but there could
be a bug in a test which wipes all the data in the project. It is
*very strongly* recommended that you only run tests against projects
which do not contain any production data or services.

Initializing conformance test data
==================================

Cross-language conformance tests are defined in a [separate
repository](https://github.com/googleapis/conformance-tests) which
is referenced as a submodule within the google-cloud-dotnet
repository.

To ensure the submodule is suitably initialized and updated (so that
the conformance test data is available locally) run this command:

```sh
git submodule update --init
```

(If your local `conformance-tests` directory contains files including a
`README.md`, that probably means all is well.)

Running tests via scripts
=========================

The `build.sh` script will run unit tests, and
`runintegrationtests.sh` will run integration tests and snippets.
(TODO: smoke tests too...)

Additionally, you can just use `dotnet test` in any test project,
optionally specifying a test filter and/or target framework.

Both `build.sh` and `runintegrationtests.sh` accept a list of
package names to build/test. So for example, to build and run all
the unit and integration tests and snippets for
`Google.Cloud.Bigtable.V2` you could run:

- `$ ./build.sh Google.Cloud.Bigtable.V2`
- `$ ./runintegrationtests.sh Google.Cloud.Bigtable.V2`

Consult the scripts for more options, such as building without
testing, or rerunning failed tests.

Running tests directly
======================

If you're working with a single API, it may be more convenient to
run the tests directly rather than using the scripts. It's usually
simplest to change to the API's root directory, and use `dotnet`
from there:

- `$ cd apis/Google.Cloud.Bigtable.V2`
- `$ dotnet test Google.Cloud.Bigtable.V2.Tests` (run the unit tests)
- `$ dotnet test Google.Cloud.Bigtable.V2.IntegrationTests` (run the integration tests)
- `$ dotnet test Google.Cloud.Bigtable.V2.Snippets` (run the snippets)

`dotnet test` always checks whether anything needs to be rebuilt
before it runs the tests, so no separate `dotnet build` step is
required.

Note that not all test types are present for all APIs.

Where a `SmokeTests` directory is present, this is not in the form
of a regular test - instead, it's a standalone application,
accepting the Google Cloud project ID as a command line argument. For example, to
run the smoke test for `Google.Cloud.Vision.V1`, you might run:

- `$ cd apis/Google.Cloud.Vision.V1`
- `$ dotnet run -p Google.Cloud.Vision.V1.SmokeTests -- your-project-name`

(The `--` is to separate `dotnet` arguments from the arguments to
pass to the application.)

Common environment variables
============================

To run the integration/smoke tests or snippets, set the following
environment variables:

- `TEST_PROJECT`: The name of the Google Cloud Project to test against
- `GOOGLE_APPLICATION_CREDENTIALS`: The absolute path to a JSON file
  containing service credentials for the test project.
- `TEST_PROJECT_LOCATION`: For APIs that require an App Engine
  project, this is the location ID of the App Engine project, such as
  "us-central1".
- `MUST_NOT_SKIP_TESTS`: If this is set to any non-empty value, tests
  that require other environment variables will fail rather than being
  skipped. (Tests that require more elaborate configuration default to
  being skipped to avoid placing an unnecessary burden on developers,
  but we want to run them in CI.)

Service account access requirements
===================================

Almost all tests can be executed using a service account with the
"Editor" role in the project. Additionally, some Storage and PubSub
tests require the "Pub/Sub Admin" role.

Per API configuration
=====================

Some APIs require a little more setup. If you're not testing an API
listed below, the instructions above should be all you need.

Google.Cloud.Bigtable.V2 and Google.Cloud.Bigtable.Admin.V2
-----------------------------------------------------------

The Bigtable integration tests can be run against the production
service or the emulator.

Running in production requires:

- A Bigtable instance, preferably of type Development, created within the
  project and identified by the `BIGTABLE_TEST_INSTANCE` environment variable
- The account identified in your service account JSON file to have read/write
  access to the project, including the IAM permissions in the Bigtable Administrator role

Running against the emulator requires:

- A running emulator on the local machine, started by using the
  `gcloud beta emulators bigtable start` command
- The `BIGTABLE_EMULATOR_HOST` environment variable set to `localhost:8086`

Currently there are no runnable snippets, but when they are added, they will
have the same requirements.

Google.Cloud.Storage.V1
-----------------------

- Enable the Google Cloud Pub/Sub API as well as Google Cloud Storage
- Follow the [instructions](https://cloud.google.com/storage/docs/encryption/using-customer-managed-keys)
  for giving the Storage service account access to Cloud KMS.

Environment variables for KMS testing (all just IDs rather than full
resource names):

- `US_KMS_TEST_KEYRING`: The ID of a keyring in the "us" location.
- `US_KMS_TEST_KEY1`: The ID of a key within the above US keyring
- `US_KMS_TEST_KEY2`: The ID of a second key within the above US keyring
- `REQUESTER_PAYS_TEST_PROJECT`: The ID of a second project to use
  when testing the "requester pays" feature.
- `REQUESTER_PAYS_CREDENTIALS`: The path to a service account credentials
  file for the requester pays project

Google.Cloud.Vision.V1
----------------------

There are two snippets which require a populated product set, and to
have AutoML configured appropriately. These tests are currently
skipped, but are preserved so it's easy to test manually when
required. To create the product set expected by the snippets, change
to the `apis/Google.Cloud.Vision.V1` directory and run:

```text
dotnet run -p Google.Cloud.Vision.V1.PopulateProductSearchTestSet -- Google.Cloud.Vision.V1.Snippets {YOUR_PROJECT_ID}
```

Wait about half an hour before running the snippets, so that the
Vision service is able to train its model appropriately.

To configure the project (in terms of permissions), visit the
[AutoML Vision console](https://cloud.google.com/automl/ui/vision/),
type in your project ID, click "Continue", and then click "Set up
now" on the next page.

Google.Cloud.Compute.V1
-----------------------

The `TEST_PROJECT_LOCATION` environment variable must be set to a
region, e.g. `us-west1`. (The value used for AppEngine testing
should be fine for Compute as well.)
