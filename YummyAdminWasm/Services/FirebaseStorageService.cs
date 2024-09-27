using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Firebase.Auth;
using Firebase.Storage;

namespace YummyAdminWasm.Services
{
    public class FirebaseStorageService
    {
         private readonly string apiKey = "AIzaSyA8rTDDaeIPRtCel7d4sySa1jwq9xaASro";
        private readonly string bucket = "yummyad-fe0c2";
        private readonly string authEmail = "adrianhernandez3p0@gmail.com";
        private readonly string authPassword = "Adrian123$#";
          
         
        public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
        {
            // Autenticar en Firebase
            // var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            // var auth = await authProvider.SignInWithEmailAndPasswordAsync(authEmail, authPassword);

            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            var auth = await authProvider.SignInWithEmailAndPasswordAsync(authEmail, authPassword);

            // Subir el archivo a Firebase Storage
            var storage = new FirebaseStorage(
                bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken),
                    ThrowOnCancel = true
                });

            var uploadTask = storage.Child("images").Child(fileName).PutAsync(fileStream);

            // Esperar a que termine la subida y obtener la URL
            var downloadUrl = await uploadTask;

            return downloadUrl;
        }

    }
}