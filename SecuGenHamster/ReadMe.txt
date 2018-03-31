1. First include both dlls as references to your project. (For the pdb file you should add it as a content to your project)
2. Import the namespace (SecuGenHamsterFPScanner) to your class:
   using SecuGenHamsterFPScanner;
3. To instantiate scanner object:
   IFingerprintScanner fingerprintScanner = new SecuGenScanner();
   fingerprintScanner.Timeout = 15000; // in milliseconeds  (Default: 10000)
4. To connect scanner device:
   fingerprintScanner.Connect(); // this will return a boolean to indicate whether the device is successfully connected or not.
5. To let the device starts waiting for a new fingerprint to be scanned:
   fingerprintScanner.ScanFingerprint(); // Check the object returned. Also note that this method may block your code for the timeout specified.
6. To check if two fingerprints data are matched:
   fingerprintScanner.DoesMatchFingerprint(fingerprint_1, fingerprint_2); // this returns boolean.
7. To disconnect scanner device:
   fingerprintScanner.Disconnect();  // this should be called before closing the application.
 